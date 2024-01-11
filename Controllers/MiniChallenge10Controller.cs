using Microsoft.AspNetCore.Mvc;
using MiniChallenge8To10.Services.MiniChallenge10;

namespace MiniChallenge8To10.Controllers;

[ApiController]
[Route("[controller]")]
public class MiniChallenge10Controller : ControllerBase
{
    private readonly IMiniChallenge10Service _miniChallenge10Service;

    public MiniChallenge10Controller(IMiniChallenge10Service miniChallenge10Service)
    {
        _miniChallenge10Service = miniChallenge10Service;
    }

    [HttpGet]
    [Route("CallPrompt")]
     public List<string> CallPrompt()
    {
        return _miniChallenge10Service.CallPrompt();
    }

    [HttpPut]
    [Route("Pick/{category}")]
    public List<string> Pick(string category)
    {
        return _miniChallenge10Service.Pick(category);
    }
}
