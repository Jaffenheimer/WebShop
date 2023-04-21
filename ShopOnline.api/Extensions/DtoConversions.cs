using ShopOnline.api.Entities;
using ShopOnline.models.Dtos;

namespace ShopOnline.api.Extensions
{
    public static class DtoConversions
    {
        public static IEnumerable<ProductDto> ConvertToDto(this IEnumerable<Product> products, IEnumerable<ProductCategory> productCategories)
        {
          return (from product in products
                  join productCategory in productCategories
                  on product.CategoryId equals productCategory.Id
                  select new ProductDto
                  {
                      Id = product.Id,
                      Name = product.Name,
                      Description = product.Description,
                      ImageURL = product.ImageURL,
                      Price = product.Price,
                      Qty = product.Qty,
                      CategoryId = productCategory.Id,
                      CategoryName = productCategory.Name
                  }).ToList();
        }

    }
}
