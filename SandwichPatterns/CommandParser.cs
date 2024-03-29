namespace SandwichPatterns;

public class CommandParser
{
    private readonly SandwichRepository _sandwiches;

    public CommandParser(SandwichRepository sandwiches)
    {
        _sandwiches = sandwiches;
    }

    public Order Parse(string line)
    {
        var args = new List<string>();

        var split1 = line.Split(',');

        foreach (var variable in split1)
        {
            var str = variable.Trim();
            var i = str.IndexOf(' ');
            args.Add(str[..i]);

            args.Add(str[(i + 1)..]);
        }

        return Parse(args.ToArray());
    }

    public Order Parse(string[] args)
    {
        var res = new Dictionary<Sandwich, int>();
        if (args.Length < 2 || args.Length % 2 != 0)
        {
            throw new Exception("Wrong arguments number");
        }

        for (var i = 0; i < args.Length - 1; i += 2)
        {
            int nb = short.Parse(args[i]);

            var sandwich = _sandwiches.GetSandwichByName(args[i + 1]);
            if (sandwich == null)
            {
                throw new Exception("undefined sandwich \"" + args[i + 1] + "\"");
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

        return new Order(res);
    }
}