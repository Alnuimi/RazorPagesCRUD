using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesCRUD.Store;

namespace RazorPagesCRUD.Pages.Products
{
    public class CreateModel(ProductStore productStore) : PageModel
    {
        [BindProperty]
        public Models.Products Product { get; set; } = new();
        public IActionResult OnGet()
        {
            return Page();
        }
        public IActionResult OnPost(Models.Products product)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            productStore.Add(product);
            return RedirectToPage("/Products/Index");
        }
    }
}
