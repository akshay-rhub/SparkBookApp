using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DataEntities
{
    public class CatagoryEntity
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string CategoryName { get; set; } = string.Empty;
        public int DisplayOrder { get; set; }
    }
}
