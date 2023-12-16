using Brogramming.Problem2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brogramming.Problem1;

public static class ProblemTwo
{
    public static void RunProblem()
    {

        var gamesString = "Game 1: 3 blue, 4 red; 1 red, 2 green, 6 blue; 2 green\r\nGame 2: 1 blue, 2 green; 3 green, 4 blue, 1 red; 1 green, 1 blue\r\nGame 3: 8 green, 6 blue, 20 red; 5 blue, 4 red, 13 green; 5 green, 1 red\r\nGame 4: 1 green, 3 red, 6 blue; 3 green, 6 red; 3 green, 15 blue, 14 red\r\nGame 5: 6 red, 1 blue, 3 green; 2 blue, 1 red, 2 green";
        var evaluator = new GameEvaluator();
        //var result = evaluator.Evaluate(gamesString, numberRed, numberGreen, numberBlue);

        ElfGameDocumentParser.ParseGame(gamesString);

        Console.WriteLine("Problem 1 Answer:" + "");

    }


}

