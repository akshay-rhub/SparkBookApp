using AutoMapper;
using BusinessLogic.APIModels;
using DataObjects;

namespace DataObjects.Services
{
    public class ModelMapper : Profile
    {
        public ModelMapper()
        {
            CreateMap<CategoryAPIModel, CategoryViewModel>().ReverseMap();
        }

    }
}
