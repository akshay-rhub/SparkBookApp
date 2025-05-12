using DataAccess.DataEntities;
using DataAccess.Helpers;
using DataAccess.Interface;
using DataObjects;

namespace DataAccess.ApiClient
{
    public class CategoryClient : ICategoryDAL
    {
        public readonly AppDBContext _db;
        public CategoryClient(AppDBContext db)
        {
            _db = db;
        }

        public List<CatagoryEntity> GetCategories()
        {
            return  _db.Book_Category.ToList();
        }
    }
}
