using Antree_Ecommerce_BE.Contract.Abstractions.Shared;
using Antree_Ecommerce_BE.Domain.Entities;
using AutoMapper;

namespace Antree_Ecommerce_BE.Application.Mapper;

using CategorySerivces = Antree_Ecommerce_BE.Contract.Services.Categories;
using ProductSerivces = Antree_Ecommerce_BE.Contract.Services.Products;

public class ServiceProfile : Profile
{
    public ServiceProfile()
    {
         CreateMap<ProductCategory, ProductSerivces.Response.ProductCategory>()
             .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
             .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description));


         CreateMap<Product, ProductSerivces.Response.ProductResponse>()
             .ForMember(dest => dest.ProductCategory,
                 opt =>
                     opt.MapFrom(src => src.ProductCategory));
         
         CreateMap<PagedResult<Product>, PagedResult<ProductSerivces.Response.ProductResponse>>()
             .ForMember(dest => dest.Items, opt => opt.MapFrom(src => src.Items));

         CreateMap<ProductCategory, CategorySerivces.Response.CategoryResponse>().ReverseMap();

         // V2
         //CreateMap<Product, Contract.Services.V2.Product.Response.ProductResponse>().ReverseMap();
    }
}