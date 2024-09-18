using System.Globalization;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using Antree_Ecommerce_BE.Application.Abstractions;
using Antree_Ecommerce_BE.Domain.Entities;
using Antree_Ecommerce_BE.Infrastructure.DependencyInjection.Options;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;


namespace Antree_Ecommerce_BE.Infrastructure.Payment.VnPay;

public class VnPayService : IVnPayService
{
    private readonly VnPayOption _vnPayOptions;
    private readonly IHttpContextAccessor _httpContextAccessor;

    public VnPayService(IOptions<VnPayOption> vnPayOptions, IHttpContextAccessor httpContextAccessor)
    {
        _httpContextAccessor = httpContextAccessor;
        _vnPayOptions = vnPayOptions.Value;
    }


    public string CreatePaymentUrl(Order model)
    {
        var timeZoneById = TimeZoneInfo.FindSystemTimeZoneById(TimeZoneInfo.Local.Id);
        var timeNow = TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, timeZoneById);
        var pay = new VnPayLibrary();

        pay.AddRequestData("vnp_Version", _vnPayOptions.Version);
        pay.AddRequestData("vnp_Command", _vnPayOptions.Command);
        pay.AddRequestData("vnp_TmnCode", _vnPayOptions.TmnCode);
        pay.AddRequestData("vnp_Amount", (10000 * 100).ToString());
        pay.AddRequestData("vnp_CreateDate", timeNow.ToString("yyyyMMddHHmmss"));
        pay.AddRequestData("vnp_CurrCode", _vnPayOptions.CurrCode);
        pay.AddRequestData("vnp_BankCode", "NCB");
        pay.AddRequestData("vnp_IpAddr", _httpContextAccessor.HttpContext.Connection.RemoteIpAddress.ToString());
        // pay.AddRequestData("vnp_IpAddr", "14.225.205.54");
        pay.AddRequestData("vnp_Locale", _vnPayOptions.Locale);
        pay.AddRequestData("vnp_OrderInfo", $"{model.Id} {model.Address} {model.Total}");
        pay.AddRequestData("vnp_OrderType", "250000");
        pay.AddRequestData("vnp_ExpireDate", timeNow.AddMinutes(2).ToString("yyyyMMddHHmmss"));
        // pay.AddRequestData("vnp_Inv_Phone", model.User.Phonenumber.Trim());
        // pay.AddRequestData("vnp_Inv_Email", model.User.Email.Trim());
        pay.AddRequestData("vnp_Inv_Address", model.Address.Trim());
        pay.AddRequestData("vnp_ReturnUrl", _vnPayOptions.UrlCallBack);
        pay.AddRequestData("vnp_TxnRef", model.Id.ToString());

        var paymentUrl =
            pay.CreateRequestUrl(_vnPayOptions.BaseUrl, _vnPayOptions.HashSecret);

        return paymentUrl;
    }

    public Order PaymentExecute(IQueryCollection collections)
    {
        throw new NotImplementedException();
    }

    public async Task<(bool IsValid, string Message)> ValidateCallback(Dictionary<string, string> vnpayData, VnPayOption options)
    {
        string vnp_SecureHash = vnpayData.FirstOrDefault(x => x.Key == "vnp_SecureHash").Value;
        if (string.IsNullOrEmpty(vnp_SecureHash))
        {
            return (false, "Invalid signature");
        }

        VnPayLibrary vnpay = new VnPayLibrary();
        foreach (var (key, value) in vnpayData.Where(x => x.Key.StartsWith("vnp_")))
        {
            if (!string.IsNullOrEmpty(value) && key != "vnp_SecureHash")
            {
                vnpay.AddResponseData(key, value);
            }
        }

        // string signValue = vnpay.GetResponseData();

        bool checkSignature = vnpay.ValidateSignature(vnp_SecureHash, options.HashSecret);
        if (!checkSignature)
        {
            return (false, "Invalid signature");
        }

        string orderId = vnpay.GetResponseData("vnp_TxnRef");
        long vnpayTranId = Convert.ToInt64(vnpay.GetResponseData("vnp_TransactionNo"));
        string vnp_ResponseCode = vnpay.GetResponseData("vnp_ResponseCode");
        string vnp_TransactionStatus = vnpay.GetResponseData("vnp_TransactionStatus");

        bool isSuccess = vnp_ResponseCode == "00" && vnp_TransactionStatus == "00";

        if (isSuccess)
        {
            //await _paymentRepository.UpdatePaymentStatusAsync(orderId, PaymentStatus.Successful, vnpayTranId);
            return (true, "Payment successful");
        }
        else
        {
           // await _paymentRepository.UpdatePaymentStatusAsync(orderId, PaymentStatus.Failed, vnpayTranId);
            return (false, $"Payment failed. Response Code: {vnp_ResponseCode}");
        }
    }
}

public class VnPayLibrary
{
    private SortedList<string, string> _requestData = new SortedList<string, string>(new VnPayCompare());
    private SortedList<string, string> _responseData = new SortedList<string, string>(new VnPayCompare());

    public void AddRequestData(string key, string value)
    {
        if (!string.IsNullOrEmpty(value))
        {
            _requestData.Add(key, value);
        }
    }

    public void AddResponseData(string key, string value)
    {
        if (!string.IsNullOrEmpty(value))
        {
            _responseData.Add(key, value);
        }
    }

    public string GetResponseData(string key)
    {
        string retValue;
        if (_responseData.TryGetValue(key, out retValue))
        {
            return retValue;
        }
        else
        {
            return string.Empty;
        }
    }

    public string CreateRequestUrl(string baseUrl, string vnp_HashSecret)
    {
        StringBuilder data = new StringBuilder();
        foreach (KeyValuePair<string, string> kv in _requestData)
        {
            if (!String.IsNullOrEmpty(kv.Value))
            {
                data.Append(WebUtility.UrlEncode(kv.Key) + "=" + WebUtility.UrlEncode(kv.Value) + "&");
            }
        }
        string queryString = data.ToString();

        baseUrl += "?" + queryString;
        String signData = queryString;
        if (signData.Length > 0)
        {
            signData = signData.Remove(data.Length - 1, 1);
        }
        string vnp_SecureHash = ComputeHmacSha512(vnp_HashSecret, signData);
        baseUrl += "vnp_SecureHash=" + vnp_SecureHash;

        return baseUrl;
    }

    public bool ValidateSignature(string inputHash, string secretKey)
    {
        string rspRaw = GetResponseData();
        string myChecksum = ComputeHmacSha512(secretKey, rspRaw);
        return myChecksum.Equals(inputHash, StringComparison.InvariantCultureIgnoreCase);
    }

    public string GetResponseData()
    {
        StringBuilder data = new StringBuilder();
        if (_responseData.ContainsKey("vnp_SecureHashType"))
        {
            _responseData.Remove("vnp_SecureHashType");
        }
        if (_responseData.ContainsKey("vnp_SecureHash"))
        {
            _responseData.Remove("vnp_SecureHash");
        }
        foreach (KeyValuePair<string, string> kv in _responseData)
        {
            if (!String.IsNullOrEmpty(kv.Value))
            {
                data.Append(WebUtility.UrlEncode(kv.Key) + "=" + WebUtility.UrlEncode(kv.Value) + "&");
            }
        }
        //remove last '&'
        if (data.Length > 0)
        {
            data.Remove(data.Length - 1, 1);
        }
        return data.ToString();
    }

    private string ComputeHmacSha512(string key, string data)
    {
        byte[] keyBytes = Encoding.UTF8.GetBytes(key);
        byte[] dataBytes = Encoding.UTF8.GetBytes(data);
        using (var hmac = new HMACSHA512(keyBytes))
        {
            var hash = hmac.ComputeHash(dataBytes);
            return BitConverter.ToString(hash).Replace("-", "").ToLower();
        }
    }
}

public class VnPayCompare : IComparer<string>
{
    public int Compare(string x, string y)
    {
        if (x == y) return 0;
        if (x == null) return -1;
        if (y == null) return 1;
        var vnpCompare = CompareInfo.GetCompareInfo("en-US");
        return vnpCompare.Compare(x, y, CompareOptions.Ordinal);
    }
}
