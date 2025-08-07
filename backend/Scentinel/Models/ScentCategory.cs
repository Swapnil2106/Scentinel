using System.ComponentModel.DataAnnotations;

namespace Scentinel.Models
{
    public class ScentCategory
    {
        [Key]
        public int ScentCategoryId { get; set; }

        [Required]
        [MaxLength(50)]
        public string CategoryName { get; set; }

        [MaxLength(500)]
        public string Description { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
