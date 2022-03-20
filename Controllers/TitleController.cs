using FluentValidation;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class TitleController : ControllerBase
{
    private readonly ITitleService _TitleService;
    private ResponseGeneratorHelper ResponseGeneratorHelper;


    public TitleController(ITitleService TitleService)
    {
        _TitleService = TitleService;
        ResponseGeneratorHelper = new ResponseGeneratorHelper();

    }

    [HttpGet]
    public async Task<ActionResult<ServiceResponse<List<Title>>>> GetAllTitle()
    {
        return await _TitleService.GetAllTitle();
    }


    //https://localhost:7231/Title/Title?Name=yazılım

    [HttpGet("Title")]
    public async Task<ActionResult<ServiceResponse<Title>>> GetTitleByName(string Name)
    {
        return await _TitleService.GetTitleByName(Name);
    }


    [HttpPost]
    public async Task<ActionResult<ServiceResponse<Title>>> CreateTitle(Title Title)
    {
        return await _TitleService.CreateTitle(Title);
    }

    
    [HttpDelete("id")]
    public async Task<ActionResult<ServiceResponse<Title>>> DeleteTitle(int id )
    {
        return await _TitleService.DeleteTitle(id);
    }


    [HttpPut]
    public async Task<ActionResult<ServiceResponse<Title>>> UpdateTitleById(TitleUpdateDTO Title)
    {
        return await _TitleService.UpdateTitleById( Title);

    }
 





}