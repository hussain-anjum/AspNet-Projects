using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TeacherProfileForm.Data;

namespace TeacherProfileForm.Pages.Teachers
{
    public class DeleteDataModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        private readonly IWebHostEnvironment _environment;

        public DeleteDataModel(ApplicationDbContext context, IWebHostEnvironment environment)
        {
            _context = context;
            _environment = environment;
        }

        public IActionResult OnGet(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var teacher = _context.Teachers.Find(id);

            if (teacher != null)
            {
                // Delete image file if exists
                if (!string.IsNullOrEmpty(teacher.Image))
                {
                    var imagePath = Path.Combine(_environment.WebRootPath, "uploads", teacher.Image);
                    if (System.IO.File.Exists(imagePath))
                    {
                        System.IO.File.Delete(imagePath);
                    }
                }

                _context.Teachers.Remove(teacher);
                _context.SaveChanges();
            }

            return RedirectToPage("/Teachers/ShowData");
        }
    }
}