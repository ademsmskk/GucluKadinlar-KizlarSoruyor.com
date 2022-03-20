using Microsoft.EntityFrameworkCore;

public class CategoryRepository : ICategoryRepository
{
    private readonly MainContext _context;
    public CategoryRepository(MainContext mainContext)
    {

        _context = mainContext;
    }

    async Task<List<Category>> ICategoryRepository.GetAllCategory()
    {
        return await _context.Set<Category>().ToListAsync();
    }
    async Task<Category> ICategoryRepository.CreateCategory(Category category)
    {
        await _context.Set<Category>().AddAsync(category);
        await _context.SaveChangesAsync();
        return category;
    }

    async Task<Category> ICategoryRepository.DeleteCategory(Category category)
    {

        _context.Set<Category>().Remove(category);
        await _context.SaveChangesAsync();
        return category;
    }

    async Task<Category> ICategoryRepository.GetCategoryByName(string Name)
    {
        return await _context.Set<Category>().FirstOrDefaultAsync(a => a.Name == Name);
    }

    async Task<Category> ICategoryRepository.UpdateCategory(Category category)
    {
        _context.Set<Category>().Update(category);
        await _context.SaveChangesAsync();
        return category;

    }
    async public Task<Category> GetCategoryById(int Id)
    {
        return await _context.Set<Category>().FirstOrDefaultAsync(x => x.Id == Id);
    }
}