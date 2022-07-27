namespace SandwichPatterns;

public class SandwichRepository
{
    private Dictionary<Sandwich, Price> Sandwich { get; }

    public SandwichRepository(Dictionary<Sandwich, Price> sandwich)
    {
        Sandwich = sandwich;
    }

    public SandwichRepository() : this(new Dictionary<Sandwich, Price>())
    {
    }

    public static SandwichRepository getDefault()
    {
        return new SandwichRepository( new Dictionary<Sandwich, Price>
        {
            {
                new("Jambon beurre", new Dictionary<Ingredient, Quantity>
                {
                    { new Ingredient("pain"), new Quantity(QuantityUnit.Unit, 1) },
                    { new Ingredient("jambon"), new Quantity(QuantityUnit.Slice, 1) },
                    { new Ingredient("beurre"), new Quantity(QuantityUnit.Gram, 10) }
                }),
                new Price( Currency.Euro, 3.5)
            },
            {
                new("Poulet crudités", new Dictionary<Ingredient, Quantity>
                {
                    { new Ingredient("pain"), new Quantity(QuantityUnit.Unit, 1) },
                    { new Ingredient("oeuf"), new Quantity(QuantityUnit.Unit, 1) },
                    { new Ingredient("tomate"), new Quantity(QuantityUnit.Unit, 0.5) },
                    { new Ingredient("poulet"), new Quantity(QuantityUnit.Unit, 1) },
                    { new Ingredient("mayonnaise"), new Quantity(QuantityUnit.Gram, 10) },
                    { new Ingredient("salade"), new Quantity(QuantityUnit.Gram, 10) }
                }),
                new Price( Currency.Euro, 5)
            },
            {
                new("Dieppois", new Dictionary<Ingredient, Quantity>
                {
                    { new Ingredient("pain"), new Quantity(QuantityUnit.Unit, 1) },
                    { new Ingredient("thon"), new Quantity(QuantityUnit.Gram, 50) },
                    { new Ingredient("tomate"), new Quantity(QuantityUnit.Unit, 0.5) },
                    { new Ingredient("mayonnaise"), new Quantity(QuantityUnit.Gram, 10) },
                    { new Ingredient("salade"), new Quantity(QuantityUnit.Gram, 10) }
                }),
                new Price( Currency.Euro, 4.5)
            }
        });
    }

    public Sandwich GetSandwichByName(string name)
    {
        return Sandwich.Keys.First(sandwich => sandwich.Name == name);
    }
    
    public Price GetSandwichPrice(string name)
    {
        return Sandwich.First(pair => pair.Key.Name == name).Value;
    }
}