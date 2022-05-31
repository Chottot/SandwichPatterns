namespace SandwichPatterns;

public class Sandwich
{
    public string Name { get; }

    public Dictionary<Ingredient, Quantity> Ingredients { get; }

    public static Dictionary<Sandwich, Price> DefaultSandwichesWithPrices()
    {
        return new Dictionary<Sandwich, Price>
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
        };
    }

    public Sandwich(string name, IDictionary<Ingredient, Quantity> ingredients)
    {
        Name = name;
        Ingredients = new Dictionary<Ingredient, Quantity>(ingredients);
        
    }

    protected bool Equals(Sandwich other)
    {
        if (Ingredients.Count != other.Ingredients.Count || Ingredients.Except(other.Ingredients).Any())
        {
            return false;
        }

        return Name.Equals(other.Name);
    }

    public override bool Equals(object? obj)
    {
        if (ReferenceEquals(null, obj)) return false;
        if (ReferenceEquals(this, obj)) return true;
        return obj.GetType() == GetType() && Equals((Sandwich)obj);
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Name, Ingredients);
    }
}