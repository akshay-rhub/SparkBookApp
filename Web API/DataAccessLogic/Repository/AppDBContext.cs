using DataAccessLogic.EntityModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLogic.Repository
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {
              
        }
        public DbSet<CategoryModel> Book_Category { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CategoryModel>().HasData(
                new CategoryModel { Id = 1, CategoryName = "Action", DisplayOrder = 1 },
                new CategoryModel { Id = 2,CategoryName = "Sci-Fi",DisplayOrder = 2}
                );
        }
    }
}
