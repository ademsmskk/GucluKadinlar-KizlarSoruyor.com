using FluentValidation;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class CategoryController : ControllerBase
{
    private readonly ICategoryService _categoryService;
    private ResponseGeneratorHelper ResponseGeneratorHelper;


    public CategoryController(ICategoryService categoryService)
    {
        _categoryService = categoryService;
        ResponseGeneratorHelper = new ResponseGeneratorHelper();

    }

    [HttpGet]
    public async Task<ActionResult<ServiceResponse<List<Category>>>> GetAllCategory()
    {
        return await _categoryService.GetAllCategory();
    }


    //https://localhost:7231/Category/Category?Name=yazılım

    [HttpGet("Category")]
    public async Task<ActionResult<ServiceResponse<Category>>> GetCategoryByName(string Name)
    {
        return await _categoryService.GetCategoryByName(Name);
    }


    [HttpPost]
    public async Task<ActionResult<ServiceResponse<Category>>> CreateCategory(Category category)
    {
        return await _categoryService.CreateCategory(category);
    }

    
    [HttpDelete("id")]
    public async Task<ActionResult<ServiceResponse<Category>>> DeleteCategory(int id )
    {
        return await _categoryService.DeleteCategory(id);
    }


    [HttpPut("update")]
    public async Task<ActionResult<ServiceResponse<Category>>> UpdateCategoryById(CategoryUpdateDTO category)
    {
        return await _categoryService.UpdateCategoryById(category);

    }
 





}