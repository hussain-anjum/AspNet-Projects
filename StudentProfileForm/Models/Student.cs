using System.ComponentModel.DataAnnotations;

namespace StudentProfileForm.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [Display(Name = "Full Name")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Father's name is required")]
        [Display(Name = "Father's Name")]
        public string FatherName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Mother's name is required")]
        [Display(Name = "Mother's Name")]
        public string MotherName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Date of birth is required")]
        [Display(Name = "Date of Birth")]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        [Required(ErrorMessage = "Gender is required")]
        public string Gender { get; set; } = string.Empty;

        [Required(ErrorMessage = "Present address is required")]
        [Display(Name = "Present Address")]
        public string PresentAddress { get; set; } = string.Empty;

        [Required(ErrorMessage = "Mobile is required")]
        [RegularExpression(@"^01[3-9][0-9]{8}$", ErrorMessage = "Please enter a valid 11-digit mobile number")]
        public string Mobile { get; set; } = string.Empty;

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        public string Email { get; set; } = string.Empty;

        [Display(Name = "Image")]
        public string? Image { get; set; }

        [Required(ErrorMessage = "Faculty is required")]
        public string Faculty { get; set; } = string.Empty;

        [Required(ErrorMessage = "Department is required")]
        public string Department { get; set; } = string.Empty;

        [Required(ErrorMessage = "Hall name is required")]
        [Display(Name = "Hall")]
        public string HallName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Roll is required")]
        public string Roll { get; set; } = string.Empty;

        [Required(ErrorMessage = "Registration number is required")]
        [Display(Name = "Reg. No")]
        public string RegNo { get; set; } = string.Empty;

        [Required(ErrorMessage = "Session is required")]
        public string Session { get; set; } = string.Empty;
    }
}