namespace SandwichPatterns;

public class CommandParser
{
    private List<Sandwich> _sandwiches;

    public CommandParser(List<Sandwich> sandwiches)
    {
        this._sandwiches = sandwiches;
    }

    public Dictionary<Sandwich, int> parse(string[] args)
    {
        throw new NotImplementedException();
    }
}