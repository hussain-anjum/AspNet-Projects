using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProductProfileForm.Data;
using ProductProfileForm.Models;

namespace ProductProfileForm.Pages.Products
{
    public class EditDataModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public EditDataModel(ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Product Product { get; set; }

        public IActionResult OnGet(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Product = _context.Products.Find(id);

            if (Product == null)
            {
                return NotFound();
            }

            return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Products.Update(Product);
            _context.SaveChanges();

            return RedirectToPage("/Products/ShowData");
        }
    }
}