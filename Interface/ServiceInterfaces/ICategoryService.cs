public interface ICategoryService
{
    Task<ServiceResponse<List<Category>>> GetAllCategory();
    Task<ServiceResponse<Category>> CreateCategory(Category category);
    Task<ServiceResponse<Category>> GetCategoryByName(string Name);
    Task<ServiceResponse<Category>> UpdateCategoryById(CategoryUpdateDTO category);
    Task<ServiceResponse<Category>> DeleteCategory(int id);
}