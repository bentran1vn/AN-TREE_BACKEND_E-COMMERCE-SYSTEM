using Antree_Ecommerce_BE.Contract.Abstractions.Shared;
using Antree_Ecommerce_BE.Domain.Entities;
using AutoMapper;

namespace Antree_Ecommerce_BE.Application.Mapper;

using CategorySerivces = Contract.Services.Categories;
using ProductSerivces = Contract.Services.Products;
using FeedbackServices = Contract.Services.Feedbacks;
using VendorServices = Contract.Services.Vendors;
using OrderServices = Contract.Services.Orders;
// using ProducMediaServices = Antree_Ecommerce_BE.Contract.Services.ProducMedia;

public class ServiceProfile : Profile
{
    public ServiceProfile()
    {
        // ============= ProductSerivces =============
        CreateMap<ProductFeedback, ProductSerivces.Response.ProductFeedback>()
            .ForMember(dest => dest.Total, opt => opt.MapFrom(src => src.Total))
            .ForMember(dest => dest.Rate, opt => opt.MapFrom(src => src.Rate));
        
        //Get All
        CreateMap<Product, ProductSerivces.Response.ProductsResponse>()
            .ForMember(dest => dest.ProductFeedbackList,
            opt =>
                opt.MapFrom(src =>
                    src.ProductFeedbackList.Any() 
                        ? src.ProductFeedbackList.ToList()
                        : new List<ProductFeedback>()
            ));
        
        CreateMap<PagedResult<Product>, PagedResult<ProductSerivces.Response.ProductsResponse>>()
            .ForMember(dest => dest.Items, opt => opt.MapFrom(src => src.Items));
        
        // Get By Detail
         CreateMap<ProductCategory, ProductSerivces.Response.ProductCategory>()
             .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
             .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description));

         CreateMap<ProductMedia, ProductSerivces.Response.ProductMedia>()
             .ForMember(dest => dest.ImageUrl, opt => opt.MapFrom(src => src.ImageUrl));
         
         CreateMap<Product, ProductSerivces.Response.ProductResponse>()
             .ForMember(dest => dest.ProductCategory,
                 opt =>
                     opt.MapFrom(src => src.ProductCategory))
             .ForMember(dest => dest.ProductImageList,
                 opt =>
                     opt.MapFrom(src => src.ProductImageList))
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
         CreateMap<User, FeedbackServices.Response.User>().ReverseMap();
         
         CreateMap<Order, FeedbackServices.Response.Order>().ReverseMap();

         CreateMap<OrderDetailFeedback, FeedbackServices.Response.OrderDetailFeedback>();
         
         CreateMap<OrderDetail, FeedbackServices.Response.FeedbackResonse>()
             .ForMember(dest => dest.Order,
                 opt =>
                     opt.MapFrom(src => src.Order))
             .ForMember(dest => dest.OrderDetailFeedback,
                 opt =>
                     opt.MapFrom(src => src.OrderDetailFeedback));
         
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
    }
}