using Brogramming.Problem2;

namespace BrogrammingTests.Problem2;

public class GameEvaluatorTests
{
    [Test]
    public static void GetSumOfPossibleGameIds_IsCorrect()
    {
        // Arrange
        var numberRed = 2;
        var numberGreen = 10;
        var numberBlue = 10;
        var expectedResult = 3;

        var elfGame1 = new ElfGame(1, new List<ElfHand> { new ElfHand(1, 1, 1) });
        var elfGame2 = new ElfGame(2, new List<ElfHand> { new ElfHand(2, 2, 2) });
        var elfGame3 = new ElfGame(3, new List<ElfHand> { new ElfHand(3, 3, 3) });
        var elfGames = new List<ElfGame>
        {
            elfGame1, elfGame2 , elfGame3
        };

        // Act
        var result = GameEvaluator.GetSumOfPossibleGameIds(elfGames, numberRed, numberGreen, numberBlue);
        // Assert
        Assert.That(result, Is.EqualTo(expectedResult));
    }

}
