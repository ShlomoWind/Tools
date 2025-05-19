using System;
public class Drill : Tool
{
    public Drill(int weight) : base("Drill", weight)
    {
    }
    public override void Describe()
    {
        Console.WriteLine($"tool: {this.name} \ndescribe: is An electric power tool used for drilling holes in wood, iron, concrete, and more.\nweight: {this.weight}");
    }
    public override void Use()
    {
        Console.WriteLine("use: Inserting nails");
    }
}