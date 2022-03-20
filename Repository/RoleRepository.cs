using Microsoft.EntityFrameworkCore;

public class RoleRepository : IRoleRepository
{

    private readonly MainContext _context;
    public RoleRepository(MainContext mainContext)
    {

        _context = mainContext;
    }

    async Task<List<Role>> IRoleRepository.GetAllRole()
    {
        return await _context.Set<Role>().ToListAsync();
    }
    async Task<Role> IRoleRepository.CreateRole(Role Role)
    {
        await _context.Set<Role>().AddAsync(Role);
        await _context.SaveChangesAsync();
        return Role;
    }

    async Task<Role> IRoleRepository.DeleteRole(Role Role)
    {

        _context.Set<Role>().Remove(Role);
        await _context.SaveChangesAsync();
        return Role;
    }



    async Task<Role> IRoleRepository.GetRoleByName(string Name)
    {
        return await _context.Set<Role>().FirstOrDefaultAsync(a => a.Name == Name);
    }

    async Task<Role> IRoleRepository.UpdateRole(Role Role)
    {
        _context.Set<Role>().Update(Role);
        await _context.SaveChangesAsync();
        return Role;

    }

    async public Task<Role> GetRoleById(int Id)
    {
        return await _context.Set<Role>().SingleOrDefaultAsync(x => x.Id == Id);
    }
}