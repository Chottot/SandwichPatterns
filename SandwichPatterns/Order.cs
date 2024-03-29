﻿namespace SandwichPatterns;

public class Order
{
    public Dictionary<Sandwich, int> Sandwich { get; }

    public Order(Dictionary<Sandwich, int> sandwich)
    {
        Sandwich = sandwich;
    }

    private bool Equals(Order other)
    {
        return Sandwich.Count == other.Sandwich.Count && !Sandwich.Except(other.Sandwich).Any();
    }

    public override bool Equals(object? obj)
    {
        if (ReferenceEquals(null, obj)) return false;
        if (ReferenceEquals(this, obj)) return true;
        return obj.GetType() == this.GetType() && Equals((Order)obj);
    }

    public override int GetHashCode()
    {
        return Sandwich.GetHashCode();
    }
}