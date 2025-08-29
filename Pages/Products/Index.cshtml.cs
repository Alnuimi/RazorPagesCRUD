using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesCRUD.Store;

namespace RazorPagesCRUD.Pages.Products
{
    public class IndexModel(ProductStore productStore) : PageModel
    {
        public IEnumerable<Models.Products> Products { get; set; } = [];
        public void OnGet()
        {
            Products = productStore.GetAll();
        }
    }
}
