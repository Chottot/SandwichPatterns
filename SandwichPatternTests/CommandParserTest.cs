using SandwichPatterns;

namespace SandwichPatternTests;

public class CommandParserTest
{
    private CommandParser _comandParser;
    private Sandwich _sandwich1;

    [SetUp]
    public void Setup()
    {
        _sandwich1 = new Sandwich("sandwich1", new Dictionary<Ingredient, int>());

        var sandwiches = new List<Sandwich> { _sandwich1 };

        _comandParser = new CommandParser(sandwiches);
    }

    [Test]
    public void should_get_one_sandwich1()
    {
        string[] inputs = { "1", _sandwich1.Name };
        var expected = new Dictionary<Sandwich, int> { { _sandwich1, 1 } };

        var res = _comandParser.parse(inputs);
        
        Assert.That(expected, Is.EqualTo(res));
    }
}