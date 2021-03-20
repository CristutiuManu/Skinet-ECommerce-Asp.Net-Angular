using System;
using System.Linq.Expressions;
using Core.Entities;

namespace core.Specifications
{
    public class ProductsWithTypesAndBrandsSpecification : BaseSpecification<Product>
    {
        public ProductsWithTypesAndBrandsSpecification()
        {
            AddIclude(x => x.ProductType);
            AddIclude(x => x.ProductBrand);
        }

        public ProductsWithTypesAndBrandsSpecification(int id)
        : base(x => x.Id == id)
        {
            AddIclude(x => x.ProductType);
            AddIclude(x => x.ProductBrand);
        }
    }
}