using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProductProfileForm.Data;
using ProductProfileForm.Models;

namespace ProductProfileForm.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public IndexModel(ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Product Product { get; set; }

        public string SuccessMessage { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Products.Add(Product);
            _context.SaveChanges();

            SuccessMessage = "New record created successfully";
            ModelState.Clear();
            Product = new Product(); // Clear form

            return Page();
        }
    }
}