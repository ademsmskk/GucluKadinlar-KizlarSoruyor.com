public interface IRoleService
{
    Task<ServiceResponse<List<Role>>> GetAllRole();
    Task<ServiceResponse<Role>> CreateRole(Role Role);
    Task<ServiceResponse<Role>> GetRoleByName(string Name);
    Task<ServiceResponse<Role>> UpdateRoleById(RoleUpdateDTO Role);
    Task<ServiceResponse<Role>> DeleteRole(int id);
    
}