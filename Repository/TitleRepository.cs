using Microsoft.EntityFrameworkCore;

public class TitleRepository : ITitleRepository
{

    private readonly MainContext _context;
    public TitleRepository(MainContext mainContext)
    {

        _context = mainContext;
    }

    async Task<List<Title>> ITitleRepository.GetAllTitle()
    {
        return await _context.Set<Title>().ToListAsync();
    }
    async Task<Title> ITitleRepository.CreateTitle(Title Title)
    {
        await _context.Set<Title>().AddAsync(Title);
        await _context.SaveChangesAsync();
        return Title;
    }

    async Task<Title> ITitleRepository.DeleteTitle(Title Title)
    {

        _context.Set<Title>().Remove(Title);
        await _context.SaveChangesAsync();
        return Title;
    }



    async Task<Title> ITitleRepository.GetTitleByName(string Name)
    {
        return await _context.Set<Title>().FirstOrDefaultAsync(a => a.Name == Name);
    }

    async Task<Title> ITitleRepository.UpdateTitle(Title Title)
    {
        _context.Set<Title>().Update(Title);
        await _context.SaveChangesAsync();
        return Title;

    }

    async public Task<Title> GetTitleById(int Id)
    {
        return await _context.Set<Title>().SingleOrDefaultAsync(x => x.Id == Id);
    }
}