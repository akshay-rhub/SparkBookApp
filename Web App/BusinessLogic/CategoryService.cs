using AutoMapper;
using BusinessLogic.APIModels;
using BusinessLogic.Interface;
using DataObjects;
using DataObjects.Helper;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class CategoryService : ICategory
    {
        public readonly HttpClient _httpClient;
        public readonly IMapper _mapper;
        public readonly ILogger<CategoryService> _logger;
        public CategoryService(HttpClient httpClient, IMapper mapper, ILogger<CategoryService> logger)
        {
            _httpClient = httpClient;
            _mapper = mapper;
            _logger = logger;
        }
        public async Task<List<CategoryViewModel>> GetCategories()
        {
            try
            {
                _logger.LogInformation($"Getting all categories from db");
                var endpoint = APIHelper.Get_Categories;
                var fullUrl = new Uri(_httpClient.BaseAddress! , endpoint);
                List<CategoryViewModel> categories = new List<CategoryViewModel>(); //_categoryDAL.GetCategories();
                var response = await _httpClient.GetAsync(fullUrl);
                if (response.IsSuccessStatusCode)
                {
                    var list = await response.Content.ReadFromJsonAsync<List<CategoryAPIModel>>() ?? new List<CategoryAPIModel>();
                    var categoriesList = _mapper.Map<List<CategoryViewModel>>(list);
                    return categoriesList;
                }
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error while getting categories from db {ex.Message}");
                return new List<CategoryViewModel>();
            }
            return new List<CategoryViewModel>();
        }
    }
}
