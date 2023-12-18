using Brogramming.Problem1;
using Brogramming.Problem2;

namespace BrogrammingTests.Problem1;

public class ElfGameTests
{
    [Test]
    public void GetMaxRed_IsCorrect()
    {
        // Arrange
        var expectedRed = 10;
        var expectedGreen = 71;
        var expectedBlue = 18;
        var elfHands0 = new ElfHand(4, 5, 6);
        var elfHands1 = new ElfHand(5, 4, 11);
        var elfHands2 = new ElfHand(10, 3, 12);
        var elfHands3 = new ElfHand(3, 71, 18);
        var elfHands = new List<ElfHand>
        {
            elfHands0, elfHands1 , elfHands2 , elfHands3
        };
        var elfGame = new ElfGame(1, elfHands);
        // Act
        var result = elfGame.GetMaxColours();
        // Assert
        Assert.That(result.maxRed, Is.EqualTo(expectedRed));
        Assert.That(result.maxGreen, Is.EqualTo(expectedGreen));
        Assert.That(result.maxBlue, Is.EqualTo(expectedBlue));
    }

}
