using System;

public class PipeCutter: Tool
{
    public PipeCutter(int weight) : base("PipeCutter", weight)
    {
    }
    public override void Describe()
    {
        Console.WriteLine($"\ntool: {this.name} \ndescribe: is a hand tool used for precise and clean cutting of pipes.\nweight: {this.weight}");
    }
    public override void Use()
    {
        Console.WriteLine("use: Cutting water pipes");
    }
}