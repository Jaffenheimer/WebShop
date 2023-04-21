using Microsoft.AspNetCore.Components;
using ShopOnline.models.Dtos;

namespace ShopOnline.web.Pages
{
    public class DisplayProductsBase : ComponentBase
    {
        [Parameter]
        public IEnumerable<ProductDto> Products { get; set; }
    }
}
