namespace MiniChallenge8To10.Services.MiniChallenge10;

public class MiniChallenge10Service : IMiniChallenge10Service
{
    public List<string> prompt = new();

    public MiniChallenge10Service()
    {
        prompt.Add("You don't know where to eat? I can tell you, if only you choose the category.");
        prompt.Add("Your choices are: seafood, chinese, or steakhouse");
    }

    public List<string> CallPrompt()
    {
        return prompt;
    }

    public List<string> Pick(string catgory)
    {
        Random numby = new Random();
        int bobbert = numby.Next(0, 10);

        string reply = catgory.ToLower();
        if (reply == "seafood")
        {
            string[] seafood = new string[10];
            seafood[0] = "Captain Crab";
            seafood[1] = "Misaki (sushi)";
            seafood[2] = "The Crab Zone";
            seafood[3] = "Yummy Sushi Burrito";
            seafood[4] = "Bud's Seafood grill";
            seafood[5] = "Red Lobster";
            seafood[6] = "Crawfish Noodle & Grill";
            seafood[7] = "7 Mares Grill";
            seafood[8] = "Long John Silver's";
            seafood[9] = "Jimmies Place (sushi)";
            prompt[0] = $"You chose the category {reply}.";
            prompt[1] = $"The restaurant you are going to is {seafood[bobbert]}";
        }
        else if (reply == "steakhouse")
        {
            string[] steakhouses = new string[10];
            steakhouses[0] = "Market Tavern";
            steakhouses[1] = "The Black Rabbit";
            steakhouses[2] = "The Kitchen at StoneBrier";
            steakhouses[3] = "Texas Roadhouse";
            steakhouses[4] = "DB Steakhouse";
            steakhouses[5] = "Ernie's Food & Spirits";
            steakhouses[6] = "BJ's Restuarant & Brewhouse";
            steakhouses[7] = "Peter's Steakhouse";
            steakhouses[8] = "Elkhorn Grill";
            steakhouses[9] = "Mike's Grillhouse";
            prompt[0] = $"You chose the category {reply}.";
            prompt[1] = $"The restaurant you are going to is {steakhouses[bobbert]}";
        }
        else if (reply == "chinese")
        {
            string[] chinese = new string[10];
            chinese[0] = "Tsing Tao";
            chinese[1] = "Dave Wong's";
            chinese[2] = "China Palace";
            chinese[3] = "Sherman's Buffet";
            chinese[4] = "Panda Express (you lost lmao)";
            chinese[5] = "Oriental Chef";
            chinese[6] = "Beijing Buffet";
            chinese[7] = "Peking Restuarant";
            chinese[8] = "Johnny Wokker";
            chinese[9] = "China Express at Food4Less (you lost lmao)";
            prompt[0] = $"You chose the category {reply}.";
            prompt[1] = $"The restaurant you are going to is {chinese[bobbert]}";
        }
        else
        {
            prompt[0] = $"You chose the category {reply}.";
            prompt[1] = $"It is not a valid category...";
        }
        return prompt;
    }
}