using Microsoft.AspNetCore.Mvc;
using MiniChallenge8To10.Services.MiniChallenge9;

namespace MiniChallenge8To10.Controllers;

[ApiController]
[Route("[controller]")]
public class MiniChallenge9Controller : ControllerBase
{
    private readonly IMiniChallenge9Service _miniChallenge9Service;

    public MiniChallenge9Controller(IMiniChallenge9Service miniChallenge9Service)
    {
        _miniChallenge9Service = miniChallenge9Service;
    }

    [HttpGet]
    [Route("CallPrompt")]
     public List<string> CallPrompt()
    {
        return _miniChallenge9Service.CallPrompt();
    }

    [HttpPut]
    [Route("EasyMode/{num}")]
    public List<string> EasyMode(string num)
    {
        return _miniChallenge9Service.EasyMode(num);
    }

    [HttpPut]
    [Route("MedMode/{num}")]
    public List<string> MedMode(string num)
    {
        return _miniChallenge9Service.MedMode(num);
    }

    [HttpPut]
    [Route("HardMode/{num}")]
    public List<string> HardMode(string num)
    {
        return _miniChallenge9Service.HardMode(num);
    }
}