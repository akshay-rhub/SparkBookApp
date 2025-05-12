using AutoMapper;
using DataObjects;
using SparkBook.Models;

namespace SparkBook.UI.Services
{
    public class ModelMapper : Profile
    {
        public ModelMapper()
        {
            CreateMap<Category, CategoryDTO>().ReverseMap();
        }

    }
}
