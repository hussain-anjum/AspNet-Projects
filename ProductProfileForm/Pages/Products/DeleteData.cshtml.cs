using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProductProfileForm.Data;

namespace ProductProfileForm.Pages.Products
{
    public class DeleteDataModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public DeleteDataModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = _context.Products.Find(id);

            if (product != null)
            {
                _context.Products.Remove(product);
                _context.SaveChanges();
            }

            return RedirectToPage("/Products/ShowData");
        }
    }
}