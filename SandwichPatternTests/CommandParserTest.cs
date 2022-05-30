using SandwichPatterns;

namespace SandwichPatternTests;

public class CommandParserTest
{
    private CommandParser _comandParser;
    private Sandwich _sandwich1;
    private Sandwich _sandwich2;

    [SetUp]
    public void Setup()
    {
        _sandwich1 = new Sandwich("sandwich1", new Dictionary<Ingredient, int>());
        _sandwich2 = new Sandwich("sandwich2", new Dictionary<Ingredient, int>());
        var sandwiches = new List<Sandwich> { _sandwich1, _sandwich2 };

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

    [Test]
    public void should_get_two_sandwich1()
    {
        string[] inputs = { "1", _sandwich1.Name, "1", _sandwich1.Name };
        var expected = new Dictionary<Sandwich, int> { { _sandwich1, 2 } };

        var res = _comandParser.parse(inputs);

        Assert.That(expected, Is.EqualTo(res));
    }

    [Test]
    public void should_get_one_sandwich1_and_one_sandwich2()
    {
        string[] inputs = { "1", _sandwich1.Name, "1", _sandwich2.Name };
        var expected = new Dictionary<Sandwich, int> { { _sandwich1, 1 }, { _sandwich2, 1 } };

        var res = _comandParser.parse(inputs);

        Assert.That(expected, Is.EqualTo(res));
    }
    
    [Test]
    public void should_get_Two_sandwich1_and_three_sandwich2()
    {
        string[] inputs = { "1", _sandwich2.Name, "2", _sandwich1.Name, "2", _sandwich2.Name };
        var expected = new Dictionary<Sandwich, int> { { _sandwich1, 2 }, { _sandwich2, 3 } };

        var res = _comandParser.parse(inputs);

        Assert.That(expected, Is.EqualTo(res));
    }
}