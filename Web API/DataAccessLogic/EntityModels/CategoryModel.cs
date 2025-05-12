using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLogic.EntityModels
{
    public class CategoryModel
    {
        public int Id { get; set; }
        public string CategoryName { get; set; } = string.Empty;
        public int DisplayOrder { get; set;}
    }
}
