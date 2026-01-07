using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ProductProfileForm.Data;
using ProductProfileForm.Models;

namespace ProductProfileForm.Pages.Products
{
    public class ShowDataModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public ShowDataModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Product> Products { get; set; }

        public void OnGet()
        {
            Products = _context.Products.ToList();
        }
    }
}