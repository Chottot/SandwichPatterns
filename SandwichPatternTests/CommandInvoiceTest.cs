using SandwichPatterns;

namespace SandwichPatternTests;

public class CommandInvoiceTest
{
    private StringWriter _stringWriter = new StringWriter();

    private CommandInvoice _commandInvoice = null!;
    private Sandwich _sandwich1 = null!;
    private Sandwich _sandwich2 = null!;
    private double _sandwich1Price;
    private double _sandwich2Price;

    [SetUp]
    public void Setup()
    {
        var ing1 = new Ingredient("ingredient1");
        var ing2 = new Ingredient("ingredient2");
        var ing3 = new Ingredient("ingredient3");
        var ing4 = new Ingredient("ingredient4");

        _sandwich1 = new Sandwich("sandwich1",
            new Dictionary<Ingredient, Quantity> { { ing1, new Quantity(QuantityUnit.Gram, 10) }, { ing2, new Quantity(QuantityUnit.Slice, 0.5) }, { ing3, new Quantity(QuantityUnit.Unit, 0.1) } });
        _sandwich1Price = 2.3;
        _sandwich2 = new Sandwich("sandwich2",
            new Dictionary<Ingredient, Quantity> { { ing4, new Quantity(QuantityUnit.Gram, 15) }, { ing2, new Quantity(QuantityUnit.Slice, 2) }, { ing3, new Quantity(QuantityUnit.Unit, 3) } });
        _sandwich2Price = 5.4;

        var prices = new Dictionary<Sandwich, double>
            { { _sandwich1, _sandwich1Price }, { _sandwich2, _sandwich2Price } };

        _commandInvoice = new CommandInvoice(prices);

        _stringWriter = new StringWriter();
        Console.SetOut(_stringWriter);
    }


    [Test]
    public void should_get_one_sandwich1()
    {
        var inputs = new Dictionary<Sandwich, int>()
            { { _sandwich1, 1 } };

        const string expected = "1 sandwich1\r\n\tingredient1 : 10 g\r\n\tingredient2 : 0,5 slice\r\n\tingredient3 : 0,1 \r\nPrix total : 2,3€\r\n";

        _commandInvoice.Display(inputs);

        Assert.That(_stringWriter.ToString(), Is.EqualTo(expected));
    }

    [Test]
    public void should_get_two_sandwich1()
    {
        var inputs = new Dictionary<Sandwich, int>()
            { { _sandwich1, 2 } };

        const string expected = "2 sandwich1\r\n\tingredient1 : 10 g\r\n\tingredient2 : 0,5 slice\r\n\tingredient3 : 0,1 \r\nPrix total : 4,6€\r\n";

        _commandInvoice.Display(inputs);

        Assert.That(_stringWriter.ToString(), Is.EqualTo(expected));
    }

    [Test]
    public void should_get_one_sandwich1_one_sandwich2()
    {
        var inputs = new Dictionary<Sandwich, int>()
            { { _sandwich1, 1 }, { _sandwich2, 1 } };

        const string expected = "1 sandwich1\r\n\tingredient1 : 10 g\r\n\tingredient2 : 0,5 slice\r\n\tingredient3 : 0,1 \r\n1 sandwich2\r\n\tingredient4 : 15 g\r\n\tingredient2 : 2 slice\r\n\tingredient3 : 3 \r\nPrix total : 7,7€\r\n";

        _commandInvoice.Display(inputs);

        Assert.That(_stringWriter.ToString(), Is.EqualTo(expected));
    }
}