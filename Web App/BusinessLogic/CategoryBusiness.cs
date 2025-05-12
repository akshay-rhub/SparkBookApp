using BusinessLogic.Interface;
using DataAccess.DataEntities;
using DataAccess.Interface;
using DataObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class CategoryBusiness : ICategoryBusiness
    {
        public readonly ICategoryDAL _categoryDAL;
        public CategoryBusiness(ICategoryDAL categoryDAL)
        {
            _categoryDAL = categoryDAL;
        }
        public List<CategoryDTO> GetCategories()
        {
            var catagories=  _categoryDAL.GetCategories();
            var catagoryDTO = catagories.Select
                (c => new CategoryDTO
                 {
                    Id = c.Id,
                    CatagoryName = c.CategoryName,
                    OrderId = c.DisplayOrder
                 }).ToList();
            return catagoryDTO;
        }
    }
}
