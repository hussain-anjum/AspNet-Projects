using System.ComponentModel.DataAnnotations;

namespace ProductProfileForm.Models
{
    public class Product
    {
        [Key]
        public int Product_id { get; set; }

        [Required]
        [Display(Name = "Product Name")]
        public string Product_Name { get; set; }

        [Display(Name = "Product Image")]
        public string Product_Image { get; set; }

        [Required]
        public string Category { get; set; }

        [Required]
        [Range(0, double.MaxValue)]
        public decimal Price { get; set; }

        public string Description { get; set; }

        [Required]
        [Range(0, int.MaxValue)]
        public int Quantity { get; set; }

        [Required]
        public string Manufacturer { get; set; }

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime? Release_Date { get; set; }
    }
}