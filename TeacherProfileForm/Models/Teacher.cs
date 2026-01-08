using System.ComponentModel.DataAnnotations;

namespace TeacherProfileForm.Models
{
    public class Teacher
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [Display(Name = "Full Name")]
        public string? FullName { get; set; }

        [Required]
        [Display(Name = "NID")]
        public string? NID { get; set; }

        [Required]
        public string? Gender { get; set; }

        [Required]
        [Display(Name = "Present Address")]
        public string? PresentAddress { get; set; }

        [Required]
        [Phone]
        public string? Mobile { get; set; }

        [Required]
        [EmailAddress]
        public string? Email { get; set; }

        public string? Image { get; set; }

        [Required]
        public string? Faculty { get; set; }

        [Required]
        public string? Department { get; set; }

        [Required]
        public string? Designation { get; set; }

        [Required]
        [Display(Name = "Joining Date")]
        [DataType(DataType.Date)]
        public DateTime JoiningDate { get; set; }

        [Required]
        public string? Qualification { get; set; }

        [Required]
        [Range(0, int.MaxValue)]
        public int Experience { get; set; }
    }
}