using BusinessLogic.Interface;
using DataObjects;
using DataObjects.Helper;
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
        public CategoryService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<List<CategoryDTO>> GetCategories()
        {
            try
            {

                var endpoint = APIHelper.Get_Categories;
                var fullUrl = new Uri(_httpClient.BaseAddress! , endpoint);
                List<CategoryDTO> categories = new List<CategoryDTO>(); //_categoryDAL.GetCategories();
                var response = await _httpClient.GetAsync(fullUrl);
                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadFromJsonAsync<List<CategoryDTO>>() ?? new List<CategoryDTO>();
                }
            }
            catch (Exception ex)
            {
                return new List<CategoryDTO>();
            }
            return new List<CategoryDTO>();
        }
    }
}
