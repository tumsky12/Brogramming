using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

}


//function 
//    if game is true - get ID of the game + write to list

//    Function 2
//    sum of list