using System.ComponentModel.DataAnnotations;

namespace SparkBook.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; } = string.Empty;
        public int Displayorder { get; set; }

    }
}
