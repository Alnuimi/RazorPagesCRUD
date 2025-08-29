using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesCRUD.Store;

namespace RazorPagesCRUD.Pages.Products
{
    public class EditModel(ProductStore productStore) : PageModel
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

        public IActionResult OnPost(Models.Products product)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            productStore.Update(product);
            return RedirectToPage("/Products/Index");
        }
    }
}
