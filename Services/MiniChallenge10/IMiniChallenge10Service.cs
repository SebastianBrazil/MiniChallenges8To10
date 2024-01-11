namespace MiniChallenge8To10.Services.MiniChallenge10;

public interface IMiniChallenge10Service
{
    List<string> Pick(string category);
    List<string> CallPrompt();
}