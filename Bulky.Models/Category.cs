using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BulkyBook.Models
{
    public class Category
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(30)]
        [DisplayName("Category Name")]
        public string Name { get; set; }
        
        [Range(1, 100, ErrorMessage = "{0} must be between {1} and {2}")]
        [DisplayName("Display Order")]
        public int DisplayOrder { get; set; }
    }
}
