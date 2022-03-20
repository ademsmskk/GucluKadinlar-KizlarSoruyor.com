using FluentValidation;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class RoleController : ControllerBase
{
    private readonly IRoleService _RoleService;
    private ResponseGeneratorHelper ResponseGeneratorHelper;


    public RoleController(IRoleService RoleService)
    {
        _RoleService = RoleService;
        ResponseGeneratorHelper = new ResponseGeneratorHelper();

    }

    [HttpGet]
    public async Task<ActionResult<ServiceResponse<List<Role>>>> GetAllRole()
    {
        return await _RoleService.GetAllRole();
    }


    //https://localhost:7231/Role/Role?Name=yazılım

    [HttpGet("Role")]
    public async Task<ActionResult<ServiceResponse<Role>>> GetRoleByName(string Name)
    {
        return await _RoleService.GetRoleByName(Name);
    }


    [HttpPost]
    public async Task<ActionResult<ServiceResponse<Role>>> CreateRole(Role Role)
    {
        return await _RoleService.CreateRole(Role);
    }

    
    [HttpDelete("delete")]
    public async Task<ActionResult<ServiceResponse<Role>>> DeleteRole(int id )
    {
        return await _RoleService.DeleteRole(id);
    }


    [HttpPut]
    public async Task<ActionResult<ServiceResponse<Role>>> UpdateRoleById(RoleUpdateDTO Role)
    {
        return await _RoleService.UpdateRoleById( Role);

    }
 





}