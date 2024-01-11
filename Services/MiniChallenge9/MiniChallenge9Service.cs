namespace MiniChallenge8To10.Services.MiniChallenge9;

public class MiniChallenge9Service : IMiniChallenge9Service
{
    public List<string> prompt = new();
    public static Random bobbert = new Random();

    public int easyGuess = bobbert.Next(1, 11);
    public int medGuess = bobbert.Next(1, 51);
    public int hardGuess = bobbert.Next(1, 101);

    public MiniChallenge9Service()
    {
        prompt.Add("Do you want to play a guessing game? It involves numbers, not people. However, you only get one guess.");
        prompt.Add("Choose between the Easy(1-10), Medium(1-50), and Hard(1-100) endpoints.");
    }

    public List<string> CallPrompt()
    {
        return prompt;
    }

    public List<string> EasyMode(string num)
    {
        prompt[0] = $"Your guess was {num}";
        double parsedNum;
        bool parsed = true;
        if (parsed != double.TryParse(num, out parsedNum))
        {
            prompt[1] = $"{num} was not a valid number, but the chosen number was {easyGuess}.";

        }
        else if (parsedNum < 0 || parsedNum > 10)
        {
            prompt[1] = $"{parsedNum} is outside the guessing zone, silly.";
        }
        else
        {
            if (parsedNum == easyGuess)
            {
                prompt[1] = $"You correctly guessed the number {easyGuess}, and you did it in one shot.";
            }
            else if (parsedNum <= easyGuess)
            {
                prompt[1] = $"You guessed the number {parsedNum} but that is less than the picked number."; //That number was {easyGuess}.
            }
            else
            {
                prompt[1] = $"You guessed the number {parsedNum} but that is more than the picked number.";  //That number was {easyGuess}.
            }
        }
        return prompt;
    }

    public List<string> MedMode(string num)
    {
        prompt[0] = $"Your guess was {num}";
        double parsedNum;
        bool parsed = true;
        if (parsed != double.TryParse(num, out parsedNum))
        {
            prompt[1] = $"{num} was not a valid number, but the chosen number was {medGuess}.";
        }
        else if (parsedNum < 0 || parsedNum > 50)
        {
            prompt[1] = $"{parsedNum} is outside the guessing zone, silly.";
        }
        else
        {
            if (parsedNum == medGuess)
            {
                prompt[1] = $"You correctly guessed the number {medGuess}, and you did it in one shot.";
            }
            else if (parsedNum <= medGuess)
            {
                prompt[1] = $"You guessed the number {parsedNum} but that is less than the picked number."; //That number was {easyGuess}.
            }
            else
            {
                prompt[1] = $"You guessed the number {parsedNum} but that is more than the picked number.";  //That number was {easyGuess}.
            }
        }
        return prompt;
    }

    public List<string> HardMode(string num)
    {
        prompt[0] = $"Your guess was {num}";
        double parsedNum;
        bool parsed = true;
        if (parsed != double.TryParse(num, out parsedNum))
        {
            prompt[1] = $"{num} was not a valid number, but the chosen number was {hardGuess}.";
        }
        else if (parsedNum < 0 || parsedNum > 100)
        {
            prompt[1] = $"{parsedNum} is outside the guessing zone, silly.";
        }
        else
        {
            if (parsedNum == hardGuess)
            {
                prompt[1] = $"You correctly guessed the number {hardGuess}, and you did it in one shot.";
            }
            else if (parsedNum <= hardGuess)
            {
                prompt[1] = $"You guessed the number {parsedNum} but that is less than the picked number."; //That number was {easyGuess}.
            }
            else
            {
                prompt[1] = $"You guessed the number {parsedNum} but that is more than the picked number.";  //That number was {easyGuess}.
            }
        }
        return prompt;
    }
}