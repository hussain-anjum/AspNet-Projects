using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace StudentProfileValidation.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public StudentInfo Student { get; set; } = new StudentInfo();

        public void OnGet()
        {
            // This runs when the page loads
        }

        public IActionResult OnPost()
        {
            // Validate the model
            if (!ModelState.IsValid)
            {
                return Page();
            }

            // Redirect to Result page with the data
            return RedirectToPage("/Result", Student);
        }
    }

    public class StudentInfo
    {
        [Required(ErrorMessage = "Please enter the student's name.")]
        [Display(Name = "Name")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter the father's name.")]
        [Display(Name = "Father's Name")]
        public string FatherName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter the mother's name.")]
        [Display(Name = "Mother's Name")]
        public string MotherName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter a valid date of birth.")]
        [Display(Name = "Date of Birth")]
        [DataType(DataType.Date)]
        [MinimumAge(3, ErrorMessage = "You must be at least 3 years old.")]
        public DateTime? DateOfBirth { get; set; }

        [Required(ErrorMessage = "Please select a gender.")]
        [Display(Name = "Sex")]
        public string Sex { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter a valid phone number.")]
        [RegularExpression(@"^01[3-9][0-9]{8}$", ErrorMessage = "Please enter a valid 11-digit phone number.")]
        [Display(Name = "Phone")]
        public string Phone { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter a valid email address.")]
        [EmailAddress(ErrorMessage = "Please enter a valid email address.")]
        [Display(Name = "Email")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter your present address.")]
        [Display(Name = "Present Address")]
        public string PresentAddress { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter your permanent address.")]
        [Display(Name = "Permanent Address")]
        public string PermanentAddress { get; set; } = string.Empty;
    }

    // Custom validation attribute for minimum age
    public class MinimumAgeAttribute : ValidationAttribute
    {
        private readonly int _minimumAge;

        public MinimumAgeAttribute(int minimumAge)
        {
            _minimumAge = minimumAge;
        }

        protected override ValidationResult IsValid(object? value, ValidationContext validationContext)
        {
            if (value is DateTime dateOfBirth)
            {
                var today = DateTime.Today;
                var age = today.Year - dateOfBirth.Year;
                
                if (dateOfBirth.Date > today.AddYears(-age))
                {
                    age--;
                }

                if (age < _minimumAge)
                {
                    return new ValidationResult(ErrorMessage ?? $"Minimum age must be {_minimumAge} years.");
                }
            }

            return ValidationResult.Success!;
        }
    }
}