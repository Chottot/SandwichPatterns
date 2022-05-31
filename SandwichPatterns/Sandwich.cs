namespace SandwichPatterns;

public class Sandwich
{
    public string Name { get; }

    public Dictionary<Ingredient, double> Ingredients { get; }

    public static Dictionary<Sandwich, double> DefaultSandwichesWithPrices()
    {
        return new Dictionary<Sandwich, double>
        {
            {
                new("Jambon beurre", new Dictionary<Ingredient, double>
                {
                    { new Ingredient("pain"), 1 },
                    { new Ingredient("tranche de jambon"), 1 },
                    { new Ingredient("beurre en g"), 10 }
                }),
                3.5
            },
            {
                new("Poulet crudités", new Dictionary<Ingredient, double>
                {
                    { new Ingredient("pain"), 1 },
                    { new Ingredient("oeuf"), 1 },
                    { new Ingredient("tomate"), 0.5 },
                    { new Ingredient("tranche de poulet"), 1 },
                    { new Ingredient("mayonnaise en g"), 10 },
                    { new Ingredient("salade en g"), 10 }
                }),
                5
            },
            {
                new("Dieppois", new Dictionary<Ingredient, double>
                {
                    { new Ingredient("pain"), 1 },
                    { new Ingredient("thon en g"), 50 },
                    { new Ingredient("tomate"), 0.5 },
                    { new Ingredient("mayonnaise en g"), 10 },
                    { new Ingredient("salade en g"), 10 }
                }),
                4.5
            }
        };
    }

    public Sandwich(string name, Dictionary<Ingredient, double> ingredients)
    {
        Name = name;
        Ingredients = ingredients;
    }
}