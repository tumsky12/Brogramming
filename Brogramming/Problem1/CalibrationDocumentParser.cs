using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brogramming.Problem1;

public class CalibrationDocumentParser
{

    public Dictionary<string, int> NumberMapping { get; set; } = new Dictionary<string, int>()
    {
        {"one", 1},
        {"two", 2},
        {"three", 3},
        {"four", 4},
        {"five", 5},
        {"six", 6},
        {"seven", 7},
        {"eight", 8},
        {"nine", 9},
        {"zero", 0},
    };

    public int GetTwoDigitNumber(string line)
    {
        var originalLine = line;
        line = InsertIntegerAfterString(line);
        string? firstDigit = null;
        string lastDigit = null;

        var characterArray = line.ToCharArray();
        // ["1", "a", "b", "c" , "2"]

        foreach (var c in characterArray)
        {
            var canParse = int.TryParse(c.ToString(), out int digit);

            if (canParse)
            {
                if (firstDigit == null)
                {
                    firstDigit = c.ToString();
                }

                lastDigit = c.ToString();
            }
        }

        var twoDigitNumber = firstDigit + lastDigit;

        return int.Parse(twoDigitNumber);
    }

    public string InsertIntegerAfterString(string line)
    {
        //eightwo45threeone
        foreach (KeyValuePair<string, int> number in NumberMapping)
        {
            var firstIndexOfNumber = line.IndexOf(number.Key);
            if (firstIndexOfNumber != -1)
                line = line.Insert(firstIndexOfNumber + 1, number.Value.ToString());

            var lastIndexOfNumber = line.LastIndexOf(number.Key);
            if (lastIndexOfNumber >= 0 && firstIndexOfNumber != lastIndexOfNumber)
                line = line.Insert(lastIndexOfNumber + 1, number.Value.ToString());
        }
        return line;
    }

    public int AddListOfDigitsTogether(List<int> digits)
    {
        return digits.Sum();
    }

    public int ParseDocument(string calibrationDocument)
    {
        var listOfDigits = new List<int>();

        var arrayOfLines = calibrationDocument.Split('\n');
        foreach (var line in arrayOfLines)
        {
            var digit = GetTwoDigitNumber(line);
            listOfDigits.Add(digit);
        }

        var result = AddListOfDigitsTogether(listOfDigits);

        return result;
    }

}
