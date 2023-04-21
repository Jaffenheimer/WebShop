using Microsoft.EntityFrameworkCore;
using ShopOnline.api.Data;
using ShopOnline.api.Entities;
using ShopOnline.api.Repositories.Contracts;

namespace ShopOnline.api.Repositories
{
    public class ProductRepository:IProductRepository
    {
        private readonly ShopOnlineDbContext shopOnlineDbContext;

        public ProductRepository(ShopOnlineDbContext shopOnlineDbContext)
        {
            this.shopOnlineDbContext = shopOnlineDbContext;
        }
        public async Task<IEnumerable<Product>> GetItems()
        {
            var products = await this.shopOnlineDbContext.Products.ToListAsync();

            return products;
        }
        public async Task<IEnumerable<ProductCategory>> GetCategories()
        {
            var categories = await this.shopOnlineDbContext.ProductCategories.ToListAsync();

            return categories;
        }
        public Task<Product> GetItem(int id)
        {
            throw new NotImplementedException();
        }
        public Task<ProductCategory> GetCategory(int id)
        {
            throw new NotImplementedException();
        }
    }
}
