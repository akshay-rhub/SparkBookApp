using DataObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Interface
{
    public interface ICategory
    {
        public Task<List<CategoryDTO>> GetCategories();
    }
}
