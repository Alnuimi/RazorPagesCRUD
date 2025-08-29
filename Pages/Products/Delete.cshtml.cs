using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesCRUD.Store;

namespace RazorPagesCRUD.Pages.Products
{
    public class DeleteModel(ProductStore productStore) : PageModel
    {
        [BindProperty]
        public Models.Products? Product { get; set; }
        public IActionResult OnGet(Guid id)
        {
            Product = productStore.GetById(id);
            if (Product is null)
            {
                return NotFound();
            }

            return Page();
        }
        
        public IActionResult OnPost(Guid id)
        {
            var product = productStore.GetById(id);
            if (product is null)
            {
                return NotFound();
            }

            productStore.Delete(id);
            return RedirectToPage("/Products/Index");
        }
    }
}
