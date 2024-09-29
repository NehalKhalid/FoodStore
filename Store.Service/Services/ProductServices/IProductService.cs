using Store.Repository.Specifications.ProductSpecifications;
using Store.Service.Helper;
using Store.Service.Services.ProductServices.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Service.Services.ProductServices
{
    public interface IProductService
    {
        Task<ProductDetailsDto> GetProductByIdAsync(int? productId);
        Task<PaginatedResultDto<ProductDetailsDto>> GetAllProductsAsync(ProductSpecification specs);
        Task<IReadOnlyList<TypeBrandDetailsDto>> GetAllBrandsAsync();
        Task<IReadOnlyList<TypeBrandDetailsDto>> GetAllTypesAsync();


    }
}
