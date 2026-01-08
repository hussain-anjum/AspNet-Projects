using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TeacherProfileForm.Data;
using TeacherProfileForm.Models;

namespace TeacherProfileForm.Pages.Teachers
{
    public class EditDataModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        private readonly IWebHostEnvironment _environment;

        public EditDataModel(ApplicationDbContext context, IWebHostEnvironment environment)
        {
            _context = context;
            _environment = environment;
        }

        [BindProperty]
        public Teacher Teacher { get; set; } = new Teacher();

        [BindProperty]
        public IFormFile? ImageFile { get; set; }

        public IActionResult OnGet(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var teacher = _context.Teachers.Find(id);

            if (teacher == null)
            {
                return NotFound();
            }

            Teacher = teacher;
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            // Handle new file upload
            if (ImageFile != null && ImageFile.Length > 0)
            {
                // Delete old image if exists
                if (!string.IsNullOrEmpty(Teacher.Image))
                {
                    var oldImagePath = Path.Combine(_environment.WebRootPath, "uploads", Teacher.Image);
                    if (System.IO.File.Exists(oldImagePath))
                    {
                        System.IO.File.Delete(oldImagePath);
                    }
                }

                // Save new image
                var uploadsFolder = Path.Combine(_environment.WebRootPath, "uploads");
                Directory.CreateDirectory(uploadsFolder);

                var uniqueFileName = Guid.NewGuid().ToString() + "_" + ImageFile.FileName;
                var filePath = Path.Combine(uploadsFolder, uniqueFileName);

                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    await ImageFile.CopyToAsync(fileStream);
                }

                Teacher.Image = uniqueFileName;
            }

            _context.Teachers.Update(Teacher);
            await _context.SaveChangesAsync();

            return RedirectToPage("/Teachers/ShowData");
        }
    }
}