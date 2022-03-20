public interface IRoleRepository
{

    Task<List<Role>> GetAllRole();
    Task<Role> CreateRole(Role Role);
    Task<Role> GetRoleByName(string Name);
    Task<Role> GetRoleById(int Id);
    Task<Role> UpdateRole(Role Role);
    Task<Role> DeleteRole(Role Role);
    

}