using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObjects
{
    public class CategoryDTO
    {
        public int Id { get; set; }
        public string CatagoryName { get; set; } = string.Empty;
        public int OrderId { get; set; }
    }
}
