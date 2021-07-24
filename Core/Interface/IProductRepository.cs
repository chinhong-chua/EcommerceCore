using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Entities;

namespace Core.Interface
{
    public interface IProductRepository 
    {
         Task<Product> GetProductByIdAsync (int id);

         Task<IReadOnlyList<Product>> GetProductsAsync();

         Task<IReadOnlyList<ProductBrand>> GetProductBrands();
         Task<IReadOnlyList<ProductType>> GetProductTypes();
    }
}