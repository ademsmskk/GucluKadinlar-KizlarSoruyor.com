public interface ITitleService
{
    Task<ServiceResponse<List<Title>>> GetAllTitle();
    Task<ServiceResponse<Title>> CreateTitle(Title Title);
    Task<ServiceResponse<Title>> GetTitleByName(string Name);
    Task<ServiceResponse<Title>> UpdateTitleById(TitleUpdateDTO Title);
    Task<ServiceResponse<Title>> DeleteTitle(int id);
    
}