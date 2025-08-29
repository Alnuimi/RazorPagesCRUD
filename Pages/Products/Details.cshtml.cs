using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesCRUD.Store;

namespace RazorPagesCRUD.Pages.Products
{
    public class DetailsModel(ProductStore productStore) : PageModel
    {
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
    }
}
