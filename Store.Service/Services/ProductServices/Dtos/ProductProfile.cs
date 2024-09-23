using AutoMapper;
using Store.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Service.Services.ProductServices.Dtos
{
    public class ProductProfile : Profile
    {
        public ProductProfile() 
        {
            
            CreateMap<Product, ProductDetailsDto>()
                .ForMember(dest => dest.ProductBrand , options => options.MapFrom(src => src.Brand.Name))
                .ForMember(dest => dest.ProductType, options => options.MapFrom(src => src.Type.Name))
                .ForMember(dest => dest.PictureUrl , option => option.MapFrom<ProductPictureUrlResolver>());
            CreateMap<ProductBrand, TypeBrandDetailsDto>();
            CreateMap<ProductType, TypeBrandDetailsDto>();

        }
    }
}
