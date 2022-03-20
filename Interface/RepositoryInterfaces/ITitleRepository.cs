public interface ITitleRepository
{

    Task<List<Title>> GetAllTitle();
    Task<Title> CreateTitle(Title Title);
    Task<Title> GetTitleByName(string Name);
    Task<Title> GetTitleById(int Id);
    Task<Title> UpdateTitle(Title Title);
    Task<Title> DeleteTitle(Title Title);
    



}