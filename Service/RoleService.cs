public class RoleService : IRoleService
{
    private readonly IRoleRepository _RoleRepository;
    public RoleService(IRoleRepository RoleRepository)
    {
        _RoleRepository = RoleRepository;
    }

    async Task<ServiceResponse<List<Role>>> IRoleService.GetAllRole()
    {
        ServiceResponse<List<Role>> response = new ServiceResponse<List<Role>>();

        try
        {
            response.Data = await _RoleRepository.GetAllRole();
            response.ResponseCode = ResponseCodeEnum.Success;
            return response;
        }
        catch (Exception e)
        {
            response.Data = null;
            response.ResponseCode = ResponseCodeEnum.RoleOperationFail;
            return response;
        }
    }

    async Task<ServiceResponse<Role>> IRoleService.GetRoleByName(string Name)
    {

        ServiceResponse<Role> response = new ServiceResponse<Role>();
        var userfinderbyname = await _RoleRepository.GetRoleByName(Name);


        if (userfinderbyname != null)
        {
            response.ResponseCode = ResponseCodeEnum.Success;
            response.Data = userfinderbyname;
            return response;
        }
        else
        {
            response.ResponseCode = ResponseCodeEnum.RoleOperationFail;
            return response;
        }
    }
    async Task<ServiceResponse<Role>> IRoleService.CreateRole(Role Role)
    {
        ServiceResponse<Role> response = new ServiceResponse<Role>();

        Role finder = await _RoleRepository.GetRoleByName(Role.Name);
        if (finder == null)
        {
            response.ResponseCode = ResponseCodeEnum.Success;
            response.Data = await _RoleRepository.CreateRole(Role);
            return response;
        }
        else if (finder != null)
        {
            response.ResponseCode = ResponseCodeEnum.DuplicateRoleError;
            return response;
        }
        else
        {

            response.ResponseCode = ResponseCodeEnum.RoleOperationFail;
            return response;
        }
    }

    async Task<ServiceResponse<Role>> IRoleService.DeleteRole(int id)
    {
        ServiceResponse<Role> response = new ServiceResponse<Role>();

        Role finder = await _RoleRepository.GetRoleById(id);
        if (finder != null)
        {
            response.ResponseCode = ResponseCodeEnum.Success;
            response.Data = await _RoleRepository.DeleteRole(finder);
            return response;
        }
        else
        {
            response.ResponseCode = ResponseCodeEnum.RoleOperationFail;
            return response;
        }
    }



    async Task<ServiceResponse<Role>> IRoleService.UpdateRoleById(RoleUpdateDTO Role)
    {
        ServiceResponse<Role> response = new ServiceResponse<Role>();
        var updatedRole = await _RoleRepository.GetRoleById(Role.Id);
        if (updatedRole != null)
        {

            updatedRole.Name = Role.Name;
            response.ResponseCode = ResponseCodeEnum.Success;
            response.Data = await _RoleRepository.UpdateRole(updatedRole);
            return response;

        }

        else
        {
            response.ResponseCode = ResponseCodeEnum.RoleOperationFail;
            return response;
        }


    }
}