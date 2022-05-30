namespace SandwichPatterns;

public class CommandParser
{
    private List<Sandwich> sandwiches;

    public CommandParser(List<Sandwich> sandwiches)
    {
        this.sandwiches = sandwiches;
    }

    public Dictionary<Sandwich, int> parse(string[] args)
    {
        throw new NotImplementedException();
    }
}