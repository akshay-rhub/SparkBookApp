using System.ComponentModel.DataAnnotations;

namespace SparkBook.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = string.Empty;
        public int Displayorder { get; set; }

    }
}
