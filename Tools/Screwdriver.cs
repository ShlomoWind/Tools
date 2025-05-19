using System;

public class Screwdriver: Tool
{
    public Screwdriver(int weight) : base("Screwdriver", weight)
    {
    }
    public override void Describe()
    {
        Console.WriteLine($"tool: {this.name} \ndescribe: is a hand tool used to tighten or loosen screws.\nweight: {this.weight}");
    }
    public override void Use()
    {
        Console.WriteLine("use: Screwdriving");
    }
}