using SandwichPatterns;

namespace SandwichPatternTests;

public class CommandInvoiceTest
{
    private StringWriter stringWriter = new StringWriter();

    private CommandInvoice _comandInvoice;
    private Sandwich _sandwich1;
    private Sandwich _sandwich2;
    private double sandwich1Price;
    private double sandwich2Price;

    [SetUp]
    public void Setup()
    {
        var ing1 = new Ingredient("ingredient1");
        var ing2 = new Ingredient("ingredient2");
        var ing3 = new Ingredient("ingredient3");
        var ing4 = new Ingredient("ingredient4");

        _sandwich1 = new Sandwich("sandwich1",
            new Dictionary<Ingredient, int> { { ing1, 1 }, { ing2, 2 }, { ing3, 3 } });
        sandwich1Price = 2.3;
        _sandwich2 = new Sandwich("sandwich2",
            new Dictionary<Ingredient, int> { { ing4, 4 }, { ing2, 2 }, { ing3, 3 } });
        sandwich2Price = 5.4;

        var prices = new Dictionary<Sandwich, double>()
            { { _sandwich1, sandwich1Price }, { _sandwich2, sandwich2Price } };

        _comandInvoice = new CommandInvoice(prices);

        stringWriter = new StringWriter();
        Console.SetOut(stringWriter);
    }


    [Test]
    public void should_get_one_sandwich1()
    {
        var inputs = new Dictionary<Sandwich, int>()
            { { _sandwich1, 1 } };

        var expected = "1 sandwich1\r\n\tingredient1\r\n\tingredient2\r\n\tingredient3\r\n";

        _comandInvoice.display(inputs);

        Assert.That(stringWriter.ToString(), Is.EqualTo(expected));
    }

    [Test]
    public void should_get_two_sandwich1()
    {
        var inputs = new Dictionary<Sandwich, int>()
            { { _sandwich1, 2 } };

        var expected = "2 sandwich1\r\n\tingredient1\r\n\tingredient2\r\n\tingredient3\r\n";

        _comandInvoice.display(inputs);

        Assert.That(stringWriter.ToString(), Is.EqualTo(expected));
    }

    [Test]
    public void should_get_one_sandwich1_one_sandwich2()
    {
        var inputs = new Dictionary<Sandwich, int>()
            { { _sandwich1, 1 }, { _sandwich2, 1 } };

        var expected =
            "1 sandwich1\r\n\tingredient1\r\n\tingredient2\r\n\tingredient3\r\n1 sandwich2\r\n\tingredient4\r\n\tingredient2\r\n\tingredient3\r\n";

        _comandInvoice.display(inputs);

        Assert.That(stringWriter.ToString(), Is.EqualTo(expected));
    }
}