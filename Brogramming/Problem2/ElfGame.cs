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
    public (int minRed, int minGreen, int minBlue) GetMinColours()
    {
        int? minRed = null;
        int? minGreen = null;
        int? minBlue = null;
        foreach (var hand in Hands)
        {

            if (minRed == null || hand.NumberRed < minRed)
            {
                minRed = hand.NumberRed;
            }

            if (minGreen == null || hand.NumberGreen < minGreen)
            {
                minGreen = hand.NumberGreen;
            }

            if (minBlue == null || hand.NumberBlue < minBlue)
            {
                minBlue = hand.NumberBlue;
            }
        }
        return (minRed ?? 0, minGreen ?? 0, minBlue ?? 0);
    }


    public (int maxRed, int maxGreen, int maxBlue) GetMaxColours()
    {
        var maxRed = 0;
        var maxGreen = 0;
        var maxBlue = 0;
        foreach (var hand in Hands)
        {

            if (hand.NumberRed > maxRed)
            {
                maxRed = hand.NumberRed;
            }

            if (hand.NumberGreen > maxGreen)
            {
                maxGreen = hand.NumberGreen;
            }

            if (hand.NumberBlue > maxBlue)
            {
                maxBlue = hand.NumberBlue;
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
