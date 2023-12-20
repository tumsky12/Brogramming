namespace Brogramming.Problem2;

public static class GameEvaluator
{
    public static int GetSumOfPossibleGameIds(List<ElfGame> ListOfGames, int numberRed, int numberGreen, int numberBlue)
    {
        var successfulGamesList = new List<int>();
        foreach (ElfGame elfGame in ListOfGames)
        {
            if (elfGame.IsGamePossible(numberRed, numberGreen, numberBlue))
            {
                successfulGamesList.Add(elfGame.Id);
            }
        }
        return successfulGamesList.Sum();
    }

    public static int SumOfPowersOfMinimumHands(List<ElfGame> ListOfGames)
    {
        var total = 0;
        foreach (ElfGame elfGame in ListOfGames)
        {
            var minColours = elfGame.GetMaxColours();

            var power = minColours.maxRed * minColours.maxGreen * minColours.maxBlue;
            total += power;            
        }
        return total;
    }
}