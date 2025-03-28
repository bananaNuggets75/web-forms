using Polgo_Products.Models;

namespace Polgo_Products.Services
{
        public interface IProductService
        {
            Task<List<Products>> GetAllProductsAsync();
        }
   
}
