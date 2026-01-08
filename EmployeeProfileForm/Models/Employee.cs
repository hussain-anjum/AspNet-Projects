using System.ComponentModel.DataAnnotations;

namespace EmployeeProfileForm.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }

        [Required(ErrorMessage = "Full name is required")]
        [Display(Name = "Full Name")]
        public string FullName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        [Display(Name = "Email Address")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "Phone number is required")]
        [RegularExpression(@"^01[3-9][0-9]{8}$", ErrorMessage = "Please enter a valid 11-digit phone number")]
        [Display(Name = "Phone Number")]
        public string Phone { get; set; } = string.Empty;

        [Required(ErrorMessage = "Marital status is required")]
        [Display(Name = "Marital Status")]
        public string MaritalStatus { get; set; } = string.Empty;

        [Required(ErrorMessage = "Job position is required")]
        [Display(Name = "Job Position")]
        public string Position { get; set; } = string.Empty;

        [Display(Name = "Company Name")]
        public string? Company { get; set; }

        [Range(0, 50, ErrorMessage = "Experience must be between 0 and 50 years")]
        [Display(Name = "Years of Experience")]
        public int YearsOfExperience { get; set; }

        [Display(Name = "Skills")]
        public string? Skills { get; set; }
    }
}