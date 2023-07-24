using RedisCacheDemo.Model;
using RedisCacheDemo.Services.Category;

namespace RedisCacheDemo.Services.Category
{
    public interface ICategoryService
    {
        List<CategoryModel> GetAllCategory();
    }
}
