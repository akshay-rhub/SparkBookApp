using DataAccess.DataEntities;
using DataObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Interface
{
    public interface ICategoryDAL
    {
        public List<CatagoryEntity> GetCategories();
    }
}
