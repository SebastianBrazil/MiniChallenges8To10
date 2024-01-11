namespace MiniChallenge8To10.Services.MiniChallenge8;

public class MiniChallenge8Service : IMiniChallenge8Service
{
    public List<string> prompt = new();

    public MiniChallenge8Service()
    {
        prompt.Add("I can tell you your future. Just give me your question, mortal");
    }

    public List<string> CallPrompt()
    {
        return prompt;
    }

    public List<string> Ask(string question)
    {
        prompt[0] = question;

        Random numby = new Random();
        int bobbert = numby.Next(0,8);

        string[] response = new string[8];
        response[0] = "It is decisively so";
        response[1] = "More than likely, yes";
        response[2] = "Outlook seems positive";
        response[3] = "Concentrate on your question, and ask again";
        response[4] = "It is better if you don't know";
        response[5] = "Perchance";
        response[6] = "My sources say no";
        response[7] = "Don't count on it";

        prompt.Add(response[bobbert]);
        return prompt;
    }
}