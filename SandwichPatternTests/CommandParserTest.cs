using SandwichPatterns;

namespace SandwichPatternTests;

public class CommandParserTest
{
    private CommandParser _commandParser = null!;
    private Sandwich _sandwich1 = null!;
    private Sandwich _sandwich2 = null!;

    [SetUp]
    public void Setup()
    {
        _sandwich1 = new Sandwich("sandwich1", new Dictionary<Ingredient, Quantity>());
        _sandwich2 = new Sandwich("sandwich2", new Dictionary<Ingredient, Quantity>());
        var prices = new Dictionary<Sandwich, Price>
            { { _sandwich1, new Price(Currency.Euro, 0) }, { _sandwich2, new Price(Currency.Euro, 0) } };


        _commandParser = new CommandParser(new SandwichRepository(prices));
    }

    [Test]
    public void should_get_one_sandwich1()
    {
        string[] inputs = { "1", _sandwich1.Name };
        var expected = new Order(new Dictionary<Sandwich, int> { { _sandwich1, 1 } });

        var res = _commandParser.Parse(inputs);

        Assert.That(expected, Is.EqualTo(res));
    }

    [Test]
    public void should_get_one_sandwich1_from_line()
    {
        var inputs = "1 " + _sandwich1.Name;
        var expected = new Order(new Dictionary<Sandwich, int> { { _sandwich1, 1 } });

        var res = _commandParser.Parse(inputs);

        Assert.That(expected, Is.EqualTo(res));
    }

    [Test]
    public void should_get_two_sandwich1()
    {
        string[] inputs = { "1", _sandwich1.Name, "1", _sandwich1.Name };
        var expected = new Order(new Dictionary<Sandwich, int> { { _sandwich1, 2 } });

        var res = _commandParser.Parse(inputs);

        Assert.That(expected, Is.EqualTo(res));
    }

    [Test]
    public void should_get_two_sandwich1_from_one_line()
    {
        var inputs = "1 " + _sandwich1.Name + ", 1 " + _sandwich1.Name;
        var expected = new Order(new Dictionary<Sandwich, int> { { _sandwich1, 2 } });

        var res = _commandParser.Parse(inputs);

        Assert.That(expected, Is.EqualTo(res));
    }

    [Test]
    public void should_get_one_sandwich1_and_one_sandwich2()
    {
        string[] inputs = { "1", _sandwich1.Name, "1", _sandwich2.Name };
        var expected = new Order(new Dictionary<Sandwich, int> { { _sandwich1, 1 }, { _sandwich2, 1 } });

        var res = _commandParser.Parse(inputs);

        Assert.That(expected, Is.EqualTo(res));
    }

    [Test]
    public void should_get_two_sandwich1_and_three_sandwich2()
    {
        string[] inputs = { "1", _sandwich2.Name, "2", _sandwich1.Name, "2", _sandwich2.Name };
        var expected = new Order(new Dictionary<Sandwich, int> { { _sandwich1, 2 }, { _sandwich2, 3 } });

        var res = _commandParser.Parse(inputs);

        Assert.That(expected, Is.EqualTo(res));
    }

    [Test]
    public void should_get_two_sandwich1_and_three_sandwich2_from_one_line()
    {
        var inputs = "1 " + _sandwich2.Name + ", 2 " + _sandwich1.Name + ", 2 " + _sandwich2.Name;
        var expected = new Order(new Dictionary<Sandwich, int> { { _sandwich1, 2 }, { _sandwich2, 3 } });

        var res = _commandParser.Parse(inputs);

        Assert.That(expected, Is.EqualTo(res));
    }
}