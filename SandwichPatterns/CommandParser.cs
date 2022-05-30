namespace SandwichPatterns;

public class CommandParser
{
    private readonly List<Sandwich> _sandwiches;

    public CommandParser(List<Sandwich> sandwiches)
    {
        _sandwiches = sandwiches;
    }

    public Dictionary<Sandwich, int> Parse(string[] args)
    {
        var res = new Dictionary<Sandwich, int>();
        if (args.Length < 2 || args.Length % 2 != 0)
        {
            throw new Exception("Wrong arguments number");
        }

        for (var i = 0; i < args.Length - 1; i += 2)
        {
            int nb = short.Parse(args[i]);

            var sandwich = _sandwiches.Find(sandwich => sandwich.Name == args[i + 1]);
            if (sandwich == null)
            {
                throw new Exception("undefined sandwich");
            }

            if (res.ContainsKey(sandwich))
            {
                res[sandwich] += nb;
            }
            else
            {
                res.Add(sandwich, nb);
            }
        }

        return res;
    }
}