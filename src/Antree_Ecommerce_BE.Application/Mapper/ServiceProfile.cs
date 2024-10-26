using Antree_Ecommerce_BE.Contract.Abstractions.Shared;
using Antree_Ecommerce_BE.Contract.Services.Identity;
using Antree_Ecommerce_BE.Domain.Entities;
using AutoMapper;

namespace Antree_Ecommerce_BE.Application.Mapper;

using CategorySerivces = Contract.Services.Categories;
using ProductSerivces = Contract.Services.Products;
using FeedbackServices = Contract.Services.Feedbacks;
using VendorServices = Contract.Services.Vendors;
using OrderServices = Contract.Services.Orders;
using ProductDiscountsServices = Contract.Services.ProductDiscounts;
using TransactionsServices = Contract.Services.Transactions;
// using ProducMediaServices = Antree_Ecommerce_BE.Contract.Services.ProducMedia;

public class ServiceProfile : Profile
{
    public ServiceProfile()
    {
        CreateMap<User, Response.GetMe>().ReverseMap();
        
        // ============= ProductSerivces =============
        CreateMap<ProductFeedback, ProductSerivces.Response.ProductFeedback>()
            .ForMember(dest => dest.Total, opt => opt.MapFrom(src => src.Total))
            .ForMember(dest => dest.Rate, opt => opt.MapFrom(src => src.Rate));
        
        //Get All
        CreateMap<Product, ProductSerivces.Response.ProductsResponse>()
            .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
            .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
            .ForMember(dest => dest.Price, opt => opt.MapFrom(src => src.Price))
            .ForMember(dest => dest.Sku, opt => opt.MapFrom(src => src.Sku))
            .ForMember(dest => dest.Sold, opt => opt.MapFrom(src => src.Sold))
            .ForMember(dest => dest.DiscountSold, opt => opt.MapFrom(src => src.DiscountSold))
            .ForMember(dest => dest.DiscountPercent, opt => opt.MapFrom(src => src.DiscountPercent))
            .ForMember(dest => dest.CoverImage, opt => opt.MapFrom(src => src.CoverImage))
            .ForMember(dest => dest.Rating, opt => opt.MapFrom(src => 
                src.ProductFeedbackList != null && src.ProductFeedbackList.Any() 
                    ? (decimal)src.ProductFeedbackList.Average(f => f.Rate) 
                    : 0))
            .ForMember(dest => dest.VendorName, opt => opt.MapFrom(src => src.Vendor != null ? src.Vendor.Name : ""))
            .ForMember(dest => dest.VendorAvatarImage, opt => opt.MapFrom(src => src.Vendor != null ? src.Vendor.AvatarImage : ""));

        CreateMap<PagedResult<Product>, PagedResult<ProductSerivces.Response.ProductsResponse>>();
        
        // Get By Detail
         CreateMap<ProductCategory, ProductSerivces.Response.ProductCategory>()
             .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
             .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description));

         CreateMap<ProductMedia, ProductSerivces.Response.ProductMedia>()
             .ForMember(dest => dest.ImageUrl, opt => opt.MapFrom(src => src.ImageUrl));

         CreateMap<Vendor, ProductSerivces.Response.Vendor>().ReverseMap();
         
         CreateMap<Product, ProductSerivces.Response.ProductResponse>()
             .ForMember(dest => dest.ProductCategory,
                 opt =>
                     opt.MapFrom(src => src.ProductCategory))
             .ForMember(dest => dest.ProductImageList,
                 opt =>
                     opt.MapFrom(src => src.ProductImageList))
             .ForMember(dest => dest.Vendor,
                 opt =>
                     opt.MapFrom(src => src.Vendor))
             .ForMember(dest => dest.ProductFeedbackList,
                 opt =>
                     opt.MapFrom(src =>
                         src.ProductFeedbackList.Any() 
                             ? src.ProductFeedbackList.ToList()
                             : new List<ProductFeedback>()
             ));
             // .ForMember(dest => dest.ProductFeedbackList,
             // opt =>
             //     opt.MapFrom(src => src.ProductFeedbackList))
         
         CreateMap<PagedResult<Product>, PagedResult<ProductSerivces.Response.ProductResponse>>()
             .ForMember(dest => dest.Items, opt => opt.MapFrom(src => src.Items));

         // ============= CategorySerivces =============
         
         CreateMap<ProductCategory, CategorySerivces.Response.CategoryResponse>().ReverseMap();

         CreateMap<ListResult<ProductCategory>, ListResult<CategorySerivces.Response.CategoryResponse>>()
             .ForMember(dest => dest.Items, opt => opt.MapFrom(src => src.Items));
         
         // ============= FeedbackServices =============
         // CreateMap<User, FeedbackServices.Response.User>().ReverseMap();
         //
         // CreateMap<Order, FeedbackServices.Response.Order>().ReverseMap();
         //
         // CreateMap<OrderDetailFeedback, FeedbackServices.Response.OrderDetailFeedback>();
         
         // CreateMap<OrderDetail, FeedbackServices.Response.FeedbackResonse>()
         //     .ForMember(dest => dest.Order,
         //         opt =>
         //             opt.MapFrom(src => src.Order))
         //     .ForMember(dest => dest.OrderDetailFeedback,
         //         opt =>
         //             opt.MapFrom(src => src.OrderDetailFeedback));

         CreateMap<OrderDetail, FeedbackServices.Response.FeedbackResonse>()
             .ConstructUsing(src => new FeedbackServices.Response.FeedbackResonse
             {
                Id = src.OrderDetailFeedback!.Id,
                Rating = src.OrderDetailFeedback.Rating,
                Content = src.OrderDetailFeedback.Content,
                Email = src.Order.User.Email,
                Username = src.Order.User.Username,
                FeedbackImage = src.OrderDetailFeedback.OrderDetailFeedbackMediaList == null ? 
                    new List<string>() 
                    : src.OrderDetailFeedback.OrderDetailFeedbackMediaList.Select(x => x.ImageUrl).ToList(),
                CreatedOnUtc = src.OrderDetailFeedback.CreatedOnUtc
             });
         
         CreateMap<PagedResult<OrderDetail>, PagedResult<FeedbackServices.Response.FeedbackResonse>>()
             .ForMember(dest => dest.Items, opt => opt.MapFrom(src => src.Items));
         
         // ============= VendorServices =============
         CreateMap<Vendor, VendorServices.Response.VendorResponse>().ReverseMap();
         
         CreateMap<PagedResult<Vendor>, PagedResult<VendorServices.Response.VendorResponse>>()
             .ForMember(dest => dest.Items, opt => opt.MapFrom(src => src.Items));
         
         // ============= OrderServices =============
         CreateMap<Discount, OrderServices.Response.Discount>().ReverseMap();
         
         CreateMap<User, OrderServices.Response.User>().ReverseMap();
         
         CreateMap<Order, OrderServices.Response.VendorOrdersResponse>()
             .ForMember(dest => dest.User,
                 opt =>
                     opt.MapFrom(src => src.User))
             .ForMember(dest => dest.Discount,
                 opt =>
                     opt.MapFrom(src => src.Discount));
         
         CreateMap<Order, OrderServices.Response.CustomerOrdersResponse>()
             .ForMember(dest => dest.Discount,
                 opt =>
                     opt.MapFrom(src => src.Discount));
         
         CreateMap<PagedResult<Order>, PagedResult<OrderServices.Response.VendorOrdersResponse>>()
             .ForMember(dest => dest.Items, opt => opt.MapFrom(src => src.Items));
         
         CreateMap<PagedResult<Order>, PagedResult<OrderServices.Response.CustomerOrdersResponse>>()
             .ForMember(dest => dest.Items, opt => opt.MapFrom(src => src.Items));
         
         // ============= OrderServices =============

         // CreateMap<OrderDetailFeedback, OrderServices.Response.OrderDetailFeedback>()
         //     .ForMember(dest => dest.Content,
         //         opt =>
         //             opt.MapFrom(src => src.Content))
         //     .ForMember(dest => dest.Rating,
         //         opt =>
         //             opt.MapFrom(src => src.Rating))
         //     .ForMember(dest => dest.CreatedOnUtc,
         //         opt =>
         //             opt.MapFrom(src => src.CreatedOnUtc))
         //     .ForMember(dest => dest.OrderDetailFeedbackMedia,
         //         opt =>
         //             opt.MapFrom(src => 
         //                 src.OrderDetailFeedbackMediaList.Select(x => x.ImageUrl).ToList()));
         //
         // CreateMap<OrderDetail, OrderServices.Response.OrderDetail>()
         //     .ForMember(dest => dest.ProductQuantity,
         //         opt =>
         //             opt.MapFrom(src => src.ProductQuantity))
         //     .ForMember(dest => dest.ProductPrice,
         //         opt =>
         //             opt.MapFrom(src => src.ProductPrice))
         //     .ForMember(dest => dest.ProductPriceDiscount,
         //         opt =>
         //             opt.MapFrom(src => src.ProductPriceDiscount))
         //     .ForMember(dest => dest.ProductName,
         //         opt =>
         //             opt.MapFrom(src => src.Product.Name))
         //     .ForMember(dest => dest.OrderDetailFeedback,
         //         opt => opt.MapFrom(src => src.OrderDetailFeedback));;
         //
         
         CreateMap<Order, OrderServices.Response.OrderResponse>()
             .ConstructUsing(src => new OrderServices.Response.OrderResponse(
                 src.Id,
                 src.Address,
                 src.Note,
                 src.Total,
                 src.Status,
                 src.IsFeedback,
                 src.CreatedOnUtc,
                 src.Discount == null ? null : new OrderServices.Response.Discount()
                 {
                     Description = src.Discount.Description,
                     Name = src.Discount.Name,
                     DiscountPercent = src.Discount.DiscountPercent
                 }, // Directly map Discount
                 src.OrderDetailList == null ? null : src.OrderDetailList.Select(od => new OrderServices.Response.OrderDetail(){
                     Id = od.Id,
                     ProductQuantity = od.ProductQuantity,
                     ProductName = od.Product.Name,  // Assuming Name is a string
                     ProductPrice = od.ProductPrice,
                     ProductPriceDiscount = od.ProductPriceDiscount,
                     OrderDetailFeedback = od.OrderDetailFeedback == null ? null : new OrderServices.Response.OrderDetailFeedback()
                     {
                         Content = od.OrderDetailFeedback.Content,
                         Rating = od.OrderDetailFeedback.Rating,
                         CreatedOnUtc = od.OrderDetailFeedback.CreatedOnUtc,
                         OrderDetailFeedbackMedia = od.OrderDetailFeedback.OrderDetailFeedbackMediaList == null ?
                             null :
                             od.OrderDetailFeedback.OrderDetailFeedbackMediaList
                             .Select(x => x.ImageUrl).ToList()
                     } // Assuming Feedback is nullable
                 }).ToList() // Convert to List<OrderDetail> or desired collection type
             ));
         
         // ============= ProductDiscountServices =============
         CreateMap<ProductDiscount, ProductDiscountsServices.Response.GetProductDiscountsResponse>().ReverseMap();
         
         CreateMap<PagedResult<ProductDiscount>, PagedResult<ProductDiscountsServices.Response.GetProductDiscountsResponse>>()
             .ForMember(dest => dest.Items, opt => opt.MapFrom(src => src.Items));
         
         // ============= TransactionServices ================
         CreateMap<Transaction, TransactionsServices.Response.GetAllTransaction>()
             .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
             .ConstructUsing((src, context) => new TransactionsServices.Response.GetAllTransaction()
             {
                 Email = src.User.Email,
                 SubscriptionName = src.Subscription.Name,
                 Total = src.Total,
                 CreatedAt = src.CreatedOnUtc,
                 Status = src.Status
             });
         
         CreateMap<PagedResult<Transaction>, PagedResult<TransactionsServices.Response.GetAllTransaction>>()
             .ForMember(dest => dest.Items, opt => opt.MapFrom(src => src.Items));
    }
}