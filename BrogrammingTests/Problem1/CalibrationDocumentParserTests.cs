using Brogramming.Problem1;

namespace BrogrammingTests.Problem1;

public class CalibrationDocumentParserTests
{
    //[SetUp]
    //public void Setup()
    //{
    //}

    [TestCase("1abc2", 12)]
    [TestCase("treb7uchet", 77)]
    [TestCase("two1nine", 29)]
    [TestCase("eightwothree", 83)]
    [TestCase("abcone2threexyz", 13)]
    [TestCase("xtwone3four", 24)]
    [TestCase("4nineeightseven2", 42)]
    [TestCase("zoneight234", 14)]
    [TestCase("7pqrstsixteen", 76)]
    [TestCase("ddgjgcrssevensix37twooneightgt", 78)]
    public void GetTwoDigitNumber_ReturnsCorrectTwoDigitNumber(string testLine, int expectedResult)
    {
        // Arrange

        // Act
        var parser = new CalibrationDocumentParser();
        var actualResult = parser.GetTwoDigitNumber(testLine);

        // Assert
        Assert.That(expectedResult, Is.EqualTo(actualResult));
    }

    [Test]
    public void AddListOfDigitsTogether_CorrectlyAddsAllDigitsTogether()
    {
        // Arrange
        var testDigits = new List<int> { 12, 38, 15, 77 };
        var expectedResult = 142;

        // Act
        var parser = new CalibrationDocumentParser();
        var actualResult = parser.AddListOfDigitsTogether(testDigits);

        // Assert
        Assert.That(expectedResult, Is.EqualTo(actualResult));
    }

    [Test]
    public void ParseDocument_CorrectlyParsesDocument()
    {
        // Arrange
        var document = @"1abc2
pqr3stu8vwx
a1b2c3d4e5f
treb7uchet";
        var expectedResult = 142;

        // Act
        var parser = new CalibrationDocumentParser();
        var actualResult = parser.ParseDocument(document);

        // Assert
        Assert.That(expectedResult, Is.EqualTo(actualResult));
    }

    [TestCase("one", "o1ne")]
    [TestCase("asonedf", "aso1nedf")]
    [TestCase("asonedf2", "aso1nedf2")]
    [TestCase("34asonedf2", "34aso1nedf2")]

    public void InsertIntegerAfterString(string testLine, string expectedResult)
    {
        // Arrange

        // Act
        var parser = new CalibrationDocumentParser();
        var actualResult = parser.InsertIntegerAfterString(testLine);

        // Assert
        Assert.That(expectedResult, Is.EqualTo(actualResult));
    }


}
