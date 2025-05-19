using System;

public class Saw : Tool
{
    public Saw(int weight) : base("Saw", weight)
    {
    }
    public override void Describe()
    {
        Console.WriteLine($"\ntool: {this.name} \ndescribe: is used to cut materials such as wood, metal, plastic, and even concrete.\nweight: {this.weight}");
    }
    public override void Use()
    {
        Console.WriteLine("use: Wood cutting");
    }
}