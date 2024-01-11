using Microsoft.AspNetCore.Mvc;
using MiniChallenge8To10.Services.MiniChallenge8;

namespace MiniChallenge8To10.Controllers;

[ApiController]
[Route("[controller]")]
public class MiniChallenge8Controller : ControllerBase
{
    private readonly IMiniChallenge8Service _miniChallenge8Service;

    public MiniChallenge8Controller(IMiniChallenge8Service miniChallenge8Service)
    {
        _miniChallenge8Service = miniChallenge8Service;
    }

    [HttpGet]
    [Route("CallPrompt")]
     public List<string> CallPrompt()
    {
        return _miniChallenge8Service.CallPrompt();
    }

    [HttpPut]
    [Route("Ask/{question}")]
    public List<string> Ask(string question)
    {
        return _miniChallenge8Service.Ask(question);
    }
}
