using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace StudentProfileValidation.Pages
{
    public class ResultModel : PageModel
    {
        public string Name { get; set; } = string.Empty;
        public string FatherName { get; set; } = string.Empty;
        public string MotherName { get; set; } = string.Empty;
        public DateTime? DateOfBirth { get; set; }
        public string Sex { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string PresentAddress { get; set; } = string.Empty;
        public string PermanentAddress { get; set; } = string.Empty;

        public void OnGet(
            string name, 
            string fatherName, 
            string motherName, 
            DateTime? dateOfBirth, 
            string sex, 
            string phone, 
            string email, 
            string presentAddress, 
            string permanentAddress)
        {
            Name = name;
            FatherName = fatherName;
            MotherName = motherName;
            DateOfBirth = dateOfBirth;
            Sex = sex;
            Phone = phone;
            Email = email;
            PresentAddress = presentAddress;
            PermanentAddress = permanentAddress;
        }
    }
}