using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brogramming.Problem2;

public static class ElfGameDocumentParser
{
    public static ElfGame ParseGame(string document)
    {
        var line = "Game 1: 3 blue, 4 red; 1 red, 2 green, 6 blue; 2 green";
        var splitLine = line.Split(":"); // ["Game 1", "3 blue, 4 red; 1 red, 2 green, 6 blue; 2 green"]
        var gameId = int.Parse(splitLine[0].Substring(5)); // 1

        var handsString = splitLine[1].Split(";"); // ["3 blue, 4 red", "1 red, 2 green, 6 blue", " 2 green"]
        var hands = new List<ElfHand>();
        foreach (var hand in handsString)
        {
            var numberRed = 0;
            var numberGreen = 0;
            var numberBlue = 0;

            var cubes = hand.Split(','); // ["3 blue", "4 red"]
            foreach (var cube in cubes)
            {
                if (cube.Contains("red"))
                {
                    numberRed = int.Parse(cube.Trim().Split(" ")[0]);
                }

                if (cube.Contains("green"))
                {
                    numberGreen = int.Parse(cube.Trim().Split(" ")[0]);
                }

                if (cube.Contains("blue"))
                {
                    numberBlue = int.Parse(cube.Trim().Split(" ")[0]);
                }
            }

            var elfHand = new ElfHand(numberRed, numberGreen, numberBlue);
            hands.Add(elfHand);
        }

        var elfGame = new ElfGame(gameId, hands);
        return elfGame;
    }

    public static List<ElfGame> ParseGames(string document)
    {
        var arrayOfLines = document.Split('\n');
        var games = new List<ElfGame>();
        foreach (var line in arrayOfLines)
        {
            var elfGame = ParseGame(line);
            games.Add(elfGame);
        }

        return games;

    }
}