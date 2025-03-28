using Polgo_Products.Services;
using Microsoft.EntityFrameworkCore;
using Polgo_Products.Data;
using Polgo_Products.Models;

namespace Polgo_Products.Services
{
    public class ProductService : IProductService
    {
        private readonly DataContext _context;
        public ProductService(DataContext context)
        {
            _context = context;
        }
     
        public async Task<List<Products>> GetAllProductsAsync()
        {
            var result = await _context.Products.ToListAsync();
            return result;
        }
    }
}
