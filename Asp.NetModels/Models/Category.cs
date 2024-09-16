using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MyAsp.NetProject.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        [DisplayName("Category Name")]
        public  string Name { get; set; }
        [DisplayName("Display Order")]
        [Range(1,50,ErrorMessage ="Display Order Must Be Between 1-50")]
        public  int DisplayOrder { get; set; }


    }
}
