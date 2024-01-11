namespace MiniChallenge8To10.Services.MiniChallenge9;

public interface IMiniChallenge9Service
{
    List<string> EasyMode(string num);
    List<string> MedMode(string num);
    List<string> HardMode(string num);
    List<string> CallPrompt();
}