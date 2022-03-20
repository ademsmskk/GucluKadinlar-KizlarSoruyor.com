public interface ICategoryRepository
{

    Task<List<Category>> GetAllCategory();
    Task<Category> CreateCategory(Category category);
    Task<Category> GetCategoryByName(string Name);
    Task<Category> GetCategoryById(int Id);
    Task<Category> UpdateCategory(Category category);
    Task<Category> DeleteCategory(Category category);
    





}