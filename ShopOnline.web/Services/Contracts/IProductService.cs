using ShopOnline.models.Dtos;

namespace ShopOnline.web.Services.Contracts
{
    public interface IProductService
    {
        Task<IEnumerable<ProductDto>> GetItems();
    }
}
