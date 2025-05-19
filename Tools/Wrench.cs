using System;

public class Wrench : Tool
{
    public Wrench(int weight) : base("Wrench", weight)
    {
    }
    public override void Describe()
    {
        Console.WriteLine($"tool: {this.name} \ndescribe: is used to tighten or loosen bolts and nuts.\nweight: {this.weight}");
    }
    public override void Use()
    {
        Console.WriteLine("use: Tightening screws and nuts");
    }
}
}