using System.ComponentModel.DataAnnotations;

namespace Scentinel.Models
{
    public class Brand
    {

        [Key]
        public int BrandId { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [MaxLength(50)]
        public string Country { get; set; }

        [MaxLength(1000)]
        public string Description { get; set; }

        public string LogoUrl { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
