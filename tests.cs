using NUnit.Framework;
using System.IO;

[TestFixture]
public class GameTests
{
    private Game game;
    private StringWriter stringWriter;

    [SetUp]
    public void SetUp()
    {
        game = new Game();
        stringWriter = new StringWriter();
        Console.SetOut(stringWriter);
    }

    [Test]
    public void Choose_WithChoice1_IncreasesScoreBy10AndWritesMessage()
    {
        game.Choose(1);

        Assert.AreEqual(10, game.Score);
        StringAssert.Contains("You go farther into the forest and discover a treasure chest!", stringWriter.ToString());
    }

    [Test]
    public void Choose_WithChoiceNot1_DoesNotIncreaseScoreOrWriteMessage()
    {
        game.Choose(2);

        Assert.AreEqual(0, game.Score);
        StringAssert.DoesNotContain("You go farther into the forest and discover a treasure chest!", stringWriter.ToString());
    }
}