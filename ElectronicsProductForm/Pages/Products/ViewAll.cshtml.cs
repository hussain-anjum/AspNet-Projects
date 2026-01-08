using Microsoft.AspNetCore.Mvc.RazorPages;
using ElectronicsProductForm.Data;
using ElectronicsProductForm.Models;

namespace ElectronicsProductForm.Pages.Products
{
    public class ViewAllModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public ViewAllModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Electronics> Products { get; set; } = new List<Electronics>();

        public void OnGet()
        {
            Products = _context.Electronics.ToList();
        }
    }
}