using Antree_Ecommerce_BE.Application.Abstractions;

namespace Antree_Ecommerce_BE.Application.DependencyInjection.Extensions;

public static class EmailExtensions
{
    public static MailContent ForgotPasswordBody(string verifyCode, string userName, string email)
    {
        var body =  $@"
        <!DOCTYPE html>
        <html lang='en'>
        <head>
            <meta charset='UTF-8'>
            <meta name='viewport' content='width=device-width, initial-scale=1.0'>
            <title>Antree Password Reset</title>
            <style>
                body {{
                    font-family: Arial, sans-serif;
                    background-color: #f4f4f4;
                    margin: 0;
                    padding: 0;
                    color: #333;
                }}
                
                .container {{
                    max-width: 600px;
                    margin: 0 auto;
                    background-color: #fff;
                    padding: 20px;
                    border-radius: 8px;
                    box-shadow: 0 2px 10px rgba(0, 0, 0, 0.1);
                }}

                .logo {{
                    text-align: center;
                    margin-bottom: 20px;
                }}

                .logo img {{
                    max-width: 150px;
                }}

                h1 {{
                    color: #2F6D3E; /* Dark green from logo */
                    font-size: 28px;
                }}

                p {{
                    font-size: 16px;
                    line-height: 1.6;
                    color: #666;
                }}

                .verification-code {{
                    display: inline-block;
                    padding: 15px;
                    background-color: #2F6D3E; /* Dark green */
                    color: #fff;
                    font-size: 24px;
                    letter-spacing: 5px;
                    text-align: center;
                    border-radius: 5px;
                    margin: 20px 0;
                    font-family: 'Courier New', Courier, monospace;
                }}

                .footer {{
                    text-align: center;
                    margin-top: 30px;
                    font-size: 12px;
                    color: #aaa;
                }}

                .footer a {{
                    color: #C4A232; /* Gold from logo */
                    text-decoration: none;
                }}

                @media (max-width: 600px) {{
                    .container {{
                        padding: 15px;
                    }}

                    h1 {{
                        font-size: 24px;
                    }}

                    .verification-code {{
                        font-size: 20px;
                    }}
                }}
            </style>
        </head>
        <body>

            <div class='container'>                
                <h1>Antree Forgot Password Verify Code</h1>
                <p>Dear Customer [{userName}],</p>
                <p>We received a request to reset your password. Please use the verification code below to complete the process.</p>

                <div class='verification-code'>
                    {verifyCode} <!-- Dynamic code -->
                </div>

                <p>If you did not request a password reset, please ignore this email or contact support for assistance.</p>
                
                <div class='footer'>
                    <p>&copy; 2024 Antree. All rights reserved.</p>
                    <p><a href='[Unsubscribe_Link]'>Unsubscribe</a> | <a href='[Privacy_Link]'>Privacy Policy</a></p>
                </div>
            </div>

        </body>
        </html>
        ";
        return new MailContent()
        {
            Body = body,
            To = email,
            Subject = "Antree Forgot Password Verify Code"
        };
    }

    public static MailContent RequestCreateVendor(string vendorName, string vendorEmail)
    {
        var body = $@"
            <!DOCTYPE html>
            <html lang='en'>
            <head>
                <meta charset='UTF-8'>
                <meta name='viewport' content='width=device-width, initial-scale=1.0'>
                <title>Vendor Creation Request</title>
                <style>
                    body {{
                        font-family: Arial, sans-serif;
                        background-color: #f4f4f4;
                        margin: 0;
                        padding: 0;
                        color: #333;
                    }}
                    
                    .container {{
                        max-width: 600px;
                        margin: 0 auto;
                        background-color: #fff;
                        padding: 20px;
                        border-radius: 8px;
                        box-shadow: 0 2px 10px rgba(0, 0, 0, 0.1);
                    }}

                    .logo {{
                        text-align: center;
                        margin-bottom: 20px;
                    }}

                    .logo img {{
                        max-width: 150px;
                    }}

                    h1 {{
                        color: #2F6D3E; /* Dark green from logo */
                        font-size: 28px;
                    }}

                    p {{
                        font-size: 16px;
                        line-height: 1.6;
                        color: #666;
                    }}

                    .confirmation-code {{
                        display: inline-block;
                        padding: 15px;
                        background-color: #2F6D3E; /* Dark green */
                        color: #fff;
                        font-size: 24px;
                        letter-spacing: 5px;
                        text-align: center;
                        border-radius: 5px;
                        margin: 20px 0;
                        font-family: 'Courier New', Courier, monospace;
                    }}

                    .footer {{
                        text-align: center;
                        margin-top: 30px;
                        font-size: 12px;
                        color: #aaa;
                    }}

                    .footer a {{
                        color: #C4A232; /* Gold from logo */
                        text-decoration: none;
                    }}

                    @media (max-width: 600px) {{
                        .container {{
                            padding: 15px;
                        }}

                        h1 {{
                            font-size: 24px;
                        }}

                        .confirmation-code {{
                            font-size: 20px;
                        }}
                    }}
                </style>
            </head>
            <body>

                <div class='container'>                
                    <h1>Request to Create Vendor</h1>
                    <p>Dear Team,</p>
                    <p>A request has been made to create a new vendor. Please find the details below:</p>

                    <div class='confirmation-code'>
                        Vendor Name: {vendorName} <!-- Dynamic vendor name -->
                    </div>
                    <p>Vendor Email: {vendorEmail} <!-- Dynamic vendor email --></p>

                    <p>For any queries or further information, please do not hesitate to contact us.</p>
                    
                    <div class='footer'>
                        <p>&copy; 2024 Antree. All rights reserved.</p>
                        <p><a href='[Unsubscribe_Link]'>Unsubscribe</a> | <a href='[Privacy_Link]'>Privacy Policy</a></p>
                    </div>
                </div>

            </body>
            </html>
        ";
        return new MailContent()
        {
            Body = body,
            To = vendorEmail,
            Subject = "Request to Create Vendor"
        };
    }
    
    public static MailContent RespondToVendorRequest(string vendorName, string vendorEmail, bool isAccepted)
    {
        string responseMessage = isAccepted
            ? $"We are pleased to inform you that the vendor request for <strong>{vendorName}</strong> has been accepted."
            : $"We regret to inform you that the vendor request for <strong>{vendorName}</strong> has been rejected.";

        var body = $@"
            <!DOCTYPE html>
            <html lang='en'>
            <head>
                <meta charset='UTF-8'>
                <meta name='viewport' content='width=device-width, initial-scale=1.0'>
                <title>Vendor Creation Response</title>
                <style>
                    body {{
                        font-family: Arial, sans-serif;
                        background-color: #f4f4f4;
                        margin: 0;
                        padding: 0;
                        color: #333;
                    }}
                    
                    .container {{
                        max-width: 600px;
                        margin: 0 auto;
                        background-color: #fff;
                        padding: 20px;
                        border-radius: 8px;
                        box-shadow: 0 2px 10px rgba(0, 0, 0, 0.1);
                    }}

                    h1 {{
                        color: #2F6D3E; /* Dark green from logo */
                        font-size: 28px;
                    }}

                    p {{
                        font-size: 16px;
                        line-height: 1.6;
                        color: #666;
                    }}

                    .footer {{
                        text-align: center;
                        margin-top: 30px;
                        font-size: 12px;
                        color: #aaa;
                    }}

                    .footer a {{
                        color: #C4A232; /* Gold from logo */
                        text-decoration: none;
                    }}

                    @media (max-width: 600px) {{
                        .container {{
                            padding: 15px;
                        }}

                        h1 {{
                            font-size: 24px;
                        }}
                    }}
                </style>
            </head>
            <body>

                <div class='container'>                
                    <h1>Vendor Creation Response</h1>
                    <p>Dear Team,</p>
                    <p>{responseMessage}</p>

                    <p>Vendor Email: {vendorEmail}</p>

                    <p>For any further information or queries, please do not hesitate to contact us.</p>
                    
                    <div class='footer'>
                        <p>&copy; 2024 Antree. All rights reserved.</p>
                        <p><a href='[Unsubscribe_Link]'>Unsubscribe</a> | <a href='[Privacy_Link]'>Privacy Policy</a></p>
                    </div>
                </div>

            </body>
            </html>
        ";

        return new MailContent()
        {
            Body = body,
            To = vendorEmail,
            Subject = isAccepted ? "Vendor Creation Accepted" : "Vendor Creation Rejected"
        };
    }

    
    public static MailContent ConfirmUpdateVendorBody(string verifyCode, string userName, string email, string? bankAccountNumber = null, string? bankName = null, string? bankOwnerName = null, string? phoneNumber = null, string? vendorEmail = null)
{
    var vendorDetails = "";

    // Dynamically insert the provided vendor information
    if (!string.IsNullOrWhiteSpace(bankAccountNumber) && !string.IsNullOrWhiteSpace(bankName) && !string.IsNullOrWhiteSpace(bankOwnerName))
    {
        vendorDetails += $@"
            <p><strong>Bank Account Number:</strong> {bankAccountNumber}</p>
            <p><strong>Bank Name:</strong> {bankName}</p>
            <p><strong>Bank Owner Name:</strong> {bankOwnerName}</p>";
    }

    if (!string.IsNullOrWhiteSpace(phoneNumber))
    {
        vendorDetails += $@"
            <p><strong>Phone Number:</strong> {phoneNumber}</p>";
    }

    if (!string.IsNullOrWhiteSpace(vendorEmail))
    {
        vendorDetails += $@"
            <p><strong>Vendor Email:</strong> {vendorEmail}</p>";
    }

    var body = $@"
    <!DOCTYPE html>
    <html lang='en'>
    <head>
        <meta charset='UTF-8'>
        <meta name='viewport' content='width=device-width, initial-scale=1.0'>
        <title>Antree Confirm Update Vendor Information</title>
        <style>
            body {{
                font-family: Arial, sans-serif;
                background-color: #f4f4f4;
                margin: 0;
                padding: 0;
                color: #333;
            }}
            
            .container {{
                max-width: 600px;
                margin: 0 auto;
                background-color: #fff;
                padding: 20px;
                border-radius: 8px;
                box-shadow: 0 2px 10px rgba(0, 0, 0, 0.1);
            }}

            h1 {{
                color: #2F6D3E; 
                font-size: 28px;
            }}

            p {{
                font-size: 16px;
                line-height: 1.6;
                color: #666;
            }}

            .verification-code {{
                display: inline-block;
                padding: 15px;
                background-color: #2F6D3E;
                color: #fff;
                font-size: 24px;
                letter-spacing: 5px;
                text-align: center;
                border-radius: 5px;
                margin: 20px 0;
                font-family: 'Courier New', Courier, monospace;
            }}

            .footer {{
                text-align: center;
                margin-top: 30px;
                font-size: 12px;
                color: #aaa;
            }}

            .footer a {{
                color: #C4A232;
                text-decoration: none;
            }}

            @media (max-width: 600px) {{
                .container {{
                    padding: 15px;
                }}

                h1 {{
                    font-size: 24px;
                }}

                .verification-code {{
                    font-size: 20px;
                }}
            }}
        </style>
    </head>
    <body>

        <div class='container'>                
            <h1>Antree Confirm Change Vendor Information</h1>
            <p>Dear Vendor [{userName}],</p>
            <p>We received a request to change your vendor information. Please use the verification code below to complete the process.</p>

            <div class='verification-code'>
                {verifyCode} <!-- Dynamic code -->
            </div>

            <p>If you did not request a vendor information change, please ignore this email or contact support for assistance.</p>
            
            <h3>Your Vendor Information</h1>
            {vendorDetails} <!-- Vendor information here -->

            <div class='footer'>
                <p>&copy; 2024 Antree. All rights reserved.</p>
                <p><a href='[Unsubscribe_Link]'>Unsubscribe</a> | <a href='[Privacy_Link]'>Privacy Policy</a></p>
            </div>
        </div>

    </body>
    </html>
    ";

    return new MailContent()
    {
        Body = body,
        To = email,
        Subject = "Antree Vendor Information Update Verification"
    };
}
}
