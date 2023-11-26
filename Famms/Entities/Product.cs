using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Famms.Entities
{
    public class Product : PageModel
    {
        public string Name { get; set; } = null!;
        public string Image { get; set; } = null!;
        public decimal Price { get; set; }
    }
}
