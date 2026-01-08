using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ElectronicsProductForm.Data;
using ElectronicsProductForm.Models;

namespace ElectronicsProductForm.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public IndexModel(ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Electronics Product { get; set; } = new Electronics();

        public string? SuccessMessage { get; set; }
        public bool ShowProductInfo { get; set; } = false;

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            // Save to database
            _context.Electronics.Add(Product);
            _context.SaveChanges();

            SuccessMessage = "Product added successfully!";
            ShowProductInfo = true;

            // Clear the form after successful submission
            Product = new Electronics();

            // Keep the data to display
            return Page();
        }
    }
}