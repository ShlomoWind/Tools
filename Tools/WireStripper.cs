using System;

public class WireStripper : Tool
{
    public WireStripper(int weight) : base("WireStripper", weight)
    {
    }
    public override void Describe()
    {
        Console.WriteLine($"\ntool: {this.name} \ndescribe: is a tool used to remove the insulation from the outside of electrical wires.\nweight: {this.weight}");
    }
    public override void Use()
    {
        Console.WriteLine("use: Stripping insulation from electrical wires");
    }
}