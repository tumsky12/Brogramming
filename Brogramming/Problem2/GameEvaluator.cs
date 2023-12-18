using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brogramming.Problem2;

public static class GameEvaluator
{//12 red -- 13 green -- 14 blue
    public static int GetSumOfPossibleGameIds(List<ElfGame> ListOfGames, int numberRed, int numberGreen, int numberBlue)
    {
        var successfulGamesList = new List<int>();
        foreach (ElfGame elfGame in ListOfGames)
        {
            var maxColours = elfGame.GetMaxColours();
            var maxRed = maxColours.maxRed;
            var maxGreen = maxColours.maxGreen;
            var maxBlue = maxColours.maxBlue;

            var isPossible = elfGame.IsGamePossible(numberRed, numberGreen, numberBlue);
            if (elfGame.IsGamePossible(numberRed, numberGreen, numberBlue))
            {
                successfulGamesList.Add(elfGame.Id);
            }
        }
        return successfulGamesList.Sum();
    }

}


//function 
//    if game is true - get ID of the game + write to list

//    Function 2
//    sum of list