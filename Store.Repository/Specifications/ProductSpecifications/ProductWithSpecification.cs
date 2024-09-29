using Store.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Repository.Specifications.ProductSpecifications
{
    public class ProductWithSpecification : Specification<Product>
    {
        public ProductWithSpecification(ProductSpecification specs)
            : base(product => (!specs.TypeId.HasValue || product.TypeId == specs.TypeId.Value)
            && (!specs.BrandId.HasValue || product.BrandId == specs.BrandId.Value)
            && (string.IsNullOrEmpty(specs.Search) || product.Name.Trim().ToLower().Contains(specs.Search))
            )
        {
            AddInclude(x => x.Brand);
            AddInclude(x => x.Type);
            AddOrderBy(x => x.Id);
            ApplyPagination(specs.PageSize * (specs.PageIndex - 1), specs.PageSize);

            if(specs.Sort is not null)
            {
                switch (specs.Sort)
                {
                    case "priceAsc":
                        AddOrderBy(x => x.Price);
                        break;
                    case "priceDesc":
                        AddOrderByDescending(x => x.Price);
                        break;
                    default:
                        AddOrderBy(x => x.Id);
                        break;
                }
            }
        }
        public ProductWithSpecification(int? id)
            : base(product => product.Id == id)
        {
            AddInclude(x => x.Brand);
            AddInclude(x => x.Type);
        }
    }
}
