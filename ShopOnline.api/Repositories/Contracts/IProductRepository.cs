using ShopOnline.api.Entities;

namespace ShopOnline.api.Repositories.Contracts
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetItems();
        Task<IEnumerable<ProductCategory>> GetCategories();
        Task<Product>GetItem(int id);
        Task<ProductCategory> GetCategory(int id);
    }
}
