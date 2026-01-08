using Microsoft.AspNetCore.Mvc.RazorPages;
using TeacherProfileForm.Data;
using TeacherProfileForm.Models;

namespace TeacherProfileForm.Pages.Teachers
{
    public class ShowDataModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public ShowDataModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Teacher> Teachers { get; set; } = new List<Teacher>();

        public void OnGet()
        {
            Teachers = _context.Teachers.ToList();
        }
    }
}