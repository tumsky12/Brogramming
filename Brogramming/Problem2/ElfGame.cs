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

    public int GetMaxRed()
    {
        return 3;
    }


}

public class ElfHand
{
    public int NumberRed { get; set;}
    public int NumberGreen { get; set;}
    public int NumberBlue { get; set;}

    public ElfHand(int numberRed, int numberGreen, int numberBlue)
    {
        NumberRed = numberRed;
        NumberGreen = numberGreen;
        NumberBlue = numberBlue;
    }

}