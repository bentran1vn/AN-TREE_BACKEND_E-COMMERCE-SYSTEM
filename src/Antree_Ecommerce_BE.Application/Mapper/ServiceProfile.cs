using Antree_Ecommerce_BE.Contract.Abstractions.Shared;
using Antree_Ecommerce_BE.Contract.Services.Products;
using Antree_Ecommerce_BE.Domain.Entities;
using AutoMapper;

namespace Antree_Ecommerce_BE.Application.Mapper;

public class ServiceProfile : Profile
{
    public ServiceProfile()
    {
         //V1
         // Mapping for individual items
         CreateMap<ProductCategory, Response.ProductCategory>()
             .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
             .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description));


         CreateMap<Product, Response.ProductResponse>()
             .ForMember(dest => dest.ProductCategory,
                 opt =>
                     opt.MapFrom(src => src.ProductCategory));

        // Mapping for PagedResult with list
         CreateMap<PagedResult<Product>, PagedResult<Response.ProductResponse>>()
             .ForMember(dest => dest.Items, opt => opt.MapFrom(src => src.Items));
         // Other existing mappings...
         // CreateMap<PagedResult<Product>, PagedResult<Response.ProductResponse>>().ReverseMap();
         // V2
         //CreateMap<Product, Contract.Services.V2.Product.Response.ProductResponse>().ReverseMap();
    }
}