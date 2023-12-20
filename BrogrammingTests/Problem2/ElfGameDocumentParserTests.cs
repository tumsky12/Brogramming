using Brogramming.Problem2;

namespace BrogrammingTests.Problem2;

public class ElfGameDocumentParserTests
{
    //[SetUp]
    //public void Setup()
    //{
    //}

    [Test]
    public void GivenGameString_ItIsParsedCorrectly()
    {
        // Arrange
        var gameString = "Game 1: 3 blue, 4 red; 1 red, 2 green, 6 blue; 2 green";
        // Act
        var elfGame = ElfGameDocumentParser.ParseGame(gameString);
        // Assert

        Assert.That(elfGame.Id, Is.EqualTo(1));
        
        Assert.That(elfGame.Hands[0].NumberRed, Is.EqualTo(4)); // Hand 1
        Assert.That(elfGame.Hands[0].NumberBlue, Is.EqualTo(3));
        Assert.That(elfGame.Hands[0].NumberGreen, Is.EqualTo(0));

        Assert.That(elfGame.Hands[1].NumberRed, Is.EqualTo(1)); // Hand 2
        Assert.That(elfGame.Hands[1].NumberBlue, Is.EqualTo(6));
        Assert.That(elfGame.Hands[1].NumberGreen, Is.EqualTo(2));

        Assert.That(elfGame.Hands[2].NumberRed, Is.EqualTo(0)); // Hand 3
        Assert.That(elfGame.Hands[2].NumberBlue, Is.EqualTo(0));
        Assert.That(elfGame.Hands[2].NumberGreen, Is.EqualTo(2));
    }

    [Test]
    public void GivenGameDocument_ItIsParsedCorrectly()
    {
        // Arrange
        var document = "Game 1: 3 blue, 4 red; 1 red, 2 green, 6 blue; 2 green\r\nGame 2: 1 blue, 2 green; 3 green, 4 blue, 1 red; 1 green, 1 blue\r\nGame 3: 8 green, 6 blue, 20 red; 5 blue, 4 red, 13 green; 5 green, 1 red\r\nGame 4: 1 green, 3 red, 6 blue; 3 green, 6 red; 3 green, 15 blue, 14 red\r\nGame 5: 6 red, 1 blue, 3 green; 2 blue, 1 red, 2 green";
        // Act
        var elfGame = ElfGameDocumentParser.ParseGames(document);
        // Assert

        Assert.That(elfGame.Count, Is.EqualTo(5));
    }

}
