using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Core.Entities;

namespace Core.Specifications
{
    public class ProductsWithTypesAndBrandsSpecification : BaseSpecification<Product>
    {
        public ProductsWithTypesAndBrandsSpecification(string sort)
        {
            AddInclude(x =>x.ProductType);
            AddInclude(x => x.ProductBrand);
            AddOrderBy(x => x.Name);
        }

        public ProductsWithTypesAndBrandsSpecification(int id) 
        : base(x => x.Id == id)
        {
            AddInclude(x =>x.ProductType);
            AddInclude(x => x.ProductBrand);
        }
    }
}