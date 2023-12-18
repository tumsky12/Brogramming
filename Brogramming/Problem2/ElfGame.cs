using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brogramming.Problem2;

public class ElfGame
{
    public int Id { get; set; }
    public List<ElfHand> Hands { get; set; }

    public ElfGame(int id, List<ElfHand> hands)
    {
        Id = id;
        Hands = hands;
    }

    public (int maxRed, int maxGreen, int maxBlue) GetMaxColours()
    {
        var maxRed = 0;
        var maxGreen = 0;
        var maxBlue = 0;
        foreach (var hand in Hands)
        {
            var numberRed = hand.NumberRed;
            if (numberRed > maxRed)
            {
                maxRed = numberRed;
            }
            var numberGreen = hand.NumberGreen;
            if (numberGreen > maxGreen)
            {
                maxGreen = numberGreen;
            }
            var numberBlue = hand.NumberBlue;
            if (numberBlue > maxBlue)
            {
                maxBlue = numberBlue;
            }
        }
        return (maxRed, maxGreen, maxBlue);
    }

    public bool IsGamePossible(int red, int green, int blue)
    {
        var maxColours = GetMaxColours();
        if (maxColours.maxRed > red) return false;
        if (maxColours.maxGreen > green) return false;
        if (maxColours.maxBlue > blue) return false;
        return true;
    }

}
