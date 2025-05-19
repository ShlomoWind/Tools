using System;

public class Hammer : Tool
{
    public Hammer(int weight) : base("Hammer", weight)
    {
    }
    public override void Describe()
    {
        Console.WriteLine($"tool: {this.name} \ndescribe: is a hand tool used to hit, knock, and break various objects.\nweight: {this.weight}");
    }
    public override void Use()
    {
        Console.WriteLine("use: Inserting nails");
    }
}