namespace MiniChallenge8To10.Services.MiniChallenge8;

public interface IMiniChallenge8Service
{
    List<string> Ask(string question);
    List<string> CallPrompt();
}