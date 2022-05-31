namespace SandwichPatterns;

public class Sandwich
{
    public string Name { get; }

    public Dictionary<Ingredient, Quantity> Ingredients { get; }

    public static Dictionary<Sandwich, double> DefaultSandwichesWithPrices()
    {
        return new Dictionary<Sandwich, double>
        {
            {
                new("Jambon beurre", new Dictionary<Ingredient, Quantity>
                {
                    { new Ingredient("pain"), new Quantity(QuantityUnit.Unit, 1) },
                    { new Ingredient("jambon"), new Quantity(QuantityUnit.Slice, 1) },
                    { new Ingredient("beurre"), new Quantity(QuantityUnit.Gram, 10) }
                }),
                3.5
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
                5
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
                4.5
            }
        };
    }

    public Sandwich(string name, Dictionary<Ingredient, Quantity> ingredients)
    {
        Name = name;
        Ingredients = ingredients;
    }
}