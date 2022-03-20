public class CategoryService : ICategoryService
{
    private readonly ICategoryRepository _categoryRepository;
    public CategoryService(ICategoryRepository categoryRepository)
    {
        _categoryRepository = categoryRepository;
    }

    async Task<ServiceResponse<List<Category>>> ICategoryService.GetAllCategory()
    {
        ServiceResponse<List<Category>> response = new ServiceResponse<List<Category>>();

        try
        {
            response.Data = await _categoryRepository.GetAllCategory();
            response.ResponseCode = ResponseCodeEnum.GetAllCategoryOperationSuccess;
            return response;
        }
        catch (Exception e)
        {
            response.Data = null;
            response.ResponseCode = ResponseCodeEnum.GetAllCategoryOperationFail;
            return response;
        }
    }

    async Task<ServiceResponse<Category>> ICategoryService.GetCategoryByName(string Name)
    {

        ServiceResponse<Category> response = new ServiceResponse<Category>();
        var userfinderbyname = await _categoryRepository.GetCategoryByName(Name);


        if (userfinderbyname != null)
        {
            response.ResponseCode = ResponseCodeEnum.GetAccountByNameOperationSuccess;
            response.Data = userfinderbyname;
            return response;
        }
        else
        {
            response.ResponseCode = ResponseCodeEnum.GetAccountByNameOperationFail;
            return response;
        }
    }
    async Task<ServiceResponse<Category>> ICategoryService.CreateCategory(Category category)
    {
        ServiceResponse<Category> response = new ServiceResponse<Category>();

        Category finder = await _categoryRepository.GetCategoryByName(category.Name);
        if (finder == null)
        {
            response.ResponseCode = ResponseCodeEnum.CategoryCreateSuccess;
            response.Data = await _categoryRepository.CreateCategory(category);
            return response;
        }
        else if (finder != null)
        {
            response.ResponseCode = ResponseCodeEnum.DuplicateCategoryError;
            return response;
        }
        else
        {

            response.ResponseCode = ResponseCodeEnum.CategoryCreateOperationFail;
            return response;
        }
    }

    async Task<ServiceResponse<Category>> ICategoryService.DeleteCategory(int id)
    {
        ServiceResponse<Category> response = new ServiceResponse<Category>();

        Category finder = await _categoryRepository.GetCategoryById(id);
        if (finder != null)
        {
            response.ResponseCode = ResponseCodeEnum.CategoryDeleteSuccess;
            response.Data = await _categoryRepository.DeleteCategory(finder);
            return response;
        }
        else
        {
            response.ResponseCode = ResponseCodeEnum.CategoryDeleteOperationFail;
            return response;
        }
    }



    async Task<ServiceResponse<Category>> ICategoryService.UpdateCategoryById(CategoryUpdateDTO category)
    {
        ServiceResponse<Category> response = new ServiceResponse<Category>();
        var updatedCategory = await _categoryRepository.GetCategoryById(category.Id);
        if (updatedCategory != null)
        {

            updatedCategory.Name = category.Name;
            response.ResponseCode = ResponseCodeEnum.CategoryUpdateSuccess;
            response.Data = await _categoryRepository.UpdateCategory(updatedCategory);
            return response;

        }

        else
        {
            response.ResponseCode = ResponseCodeEnum.CategoryUpdateOperationFail;
            return response;
        }


    }
}