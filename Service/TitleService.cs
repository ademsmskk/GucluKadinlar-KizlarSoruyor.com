public class TitleService : ITitleService
{
    private readonly ITitleRepository _TitleRepository;
    public TitleService(ITitleRepository TitleRepository)
    {
        _TitleRepository = TitleRepository;
    }

    async Task<ServiceResponse<List<Title>>> ITitleService.GetAllTitle()
    {
        ServiceResponse<List<Title>> response = new ServiceResponse<List<Title>>();

        try
        {
            response.Data = await _TitleRepository.GetAllTitle();
            response.ResponseCode = ResponseCodeEnum.GetAllTitleOperationSuccess;
            return response;
        }
        catch (Exception e)
        {
            response.Data = null;
            response.ResponseCode = ResponseCodeEnum.GetAllTitleOperationFail;
            return response;
        }
    }

    async Task<ServiceResponse<Title>> ITitleService.GetTitleByName(string Name)
    {

        ServiceResponse<Title> response = new ServiceResponse<Title>();
        var Titlefinderbyname = await _TitleRepository.GetTitleByName(Name);


        if (Titlefinderbyname != null)
        {
            response.ResponseCode = ResponseCodeEnum.Success;
            response.Data = Titlefinderbyname;
            return response;
        }
        else
        {
            response.ResponseCode = ResponseCodeEnum.GetTitleByNameOperationFail;
            return response;
        }
    }
    async Task<ServiceResponse<Title>> ITitleService.CreateTitle(Title Title)
    {
        ServiceResponse<Title> response = new ServiceResponse<Title>();

        Title finder = await _TitleRepository.GetTitleByName(Title.Name);
        if (finder == null)
        {
            response.ResponseCode = ResponseCodeEnum.TitleCreateSuccess;
            response.Data = await _TitleRepository.CreateTitle(Title);
            return response;
        }
        else if (finder != null)
        {
            response.ResponseCode = ResponseCodeEnum.DuplicateTitleError;
            return response;
        }
        else
        {

            response.ResponseCode = ResponseCodeEnum.TitleCreateOperationFail;
            return response;
        }
    }

    async Task<ServiceResponse<Title>> ITitleService.DeleteTitle(int id)
    {
        ServiceResponse<Title> response = new ServiceResponse<Title>();

        Title finder = await _TitleRepository.GetTitleById(id);
        if (finder != null)
        {
            response.ResponseCode = ResponseCodeEnum.Success;
            response.Data = await _TitleRepository.DeleteTitle(finder);
            return response;
        }
        else
        {
            response.ResponseCode = ResponseCodeEnum.TitleDeleteOperationFail;
            return response;
        }
    }



    async Task<ServiceResponse<Title>> ITitleService.UpdateTitleById(TitleUpdateDTO Title)
    {
        ServiceResponse<Title> response = new ServiceResponse<Title>();
        var updatedTitle = await _TitleRepository.GetTitleById(Title.Id);
        if (updatedTitle != null)
        {

            updatedTitle.Name = Title.Name;
            response.ResponseCode = ResponseCodeEnum.Success;
            response.Data = await _TitleRepository.UpdateTitle(updatedTitle);
            return response;

        }

        else
        {
            response.ResponseCode = ResponseCodeEnum.TitleUpdateOperationFail;
            return response;
        }


    }
}