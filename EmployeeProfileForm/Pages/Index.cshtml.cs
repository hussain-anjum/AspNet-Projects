using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using EmployeeProfileForm.Data;
using EmployeeProfileForm.Models;

namespace EmployeeProfileForm.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public IndexModel(ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Employee Employee { get; set; } = new Employee();

        [BindProperty]
        public List<string> SelectedSkills { get; set; } = new List<string>();

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostAsync()
        {
            // Combine selected skills into comma-separated string
            if (SelectedSkills != null && SelectedSkills.Any())
            {
                Employee.Skills = string.Join(", ", SelectedSkills);
            }

            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Employees.Add(Employee);
            await _context.SaveChangesAsync();

            TempData["Message"] = "Employee data inserted successfully!";
            return RedirectToPage("/Employees");
        }
    }
}