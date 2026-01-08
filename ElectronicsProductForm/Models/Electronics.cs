using System.ComponentModel.DataAnnotations;

namespace ElectronicsProductForm.Models
{
    public class Electronics
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Product Name")]
        public string? ProductName { get; set; }

        [Required]
        public string? Brand { get; set; }

        [Required]
        [Display(Name = "Model Number")]
        public string? ModelNumber { get; set; }

        [Required]
        public string? Category { get; set; }

        [Required]
        [Range(0.01, double.MaxValue, ErrorMessage = "Price must be greater than 0")]
        [Display(Name = "Price (USD)")]
        public decimal Price { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Quantity must be at least 1")]
        public int Quantity { get; set; }

        [Required]
        [Range(0, int.MaxValue)]
        [Display(Name = "Warranty Period (months)")]
        public int WarrantyMonths { get; set; }

        [Required]
        public string? Description { get; set; }
    }
}