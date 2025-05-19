using System;

public class Tool
{
    protected string name;
    protected int weight;

    public Tool(string name, int weight)
    {
        this.name = name;
        this.weight = weight;
    }
    public string GetName()
    {
        return this.name;
    }
    public virtual void Describe()
    {
        Console.WriteLine($"\ntool: {this.name} \nweight: {this.weight}");
    }
    public virtual void Use()
    {
        Console.WriteLine("Tool is being used");
    }
}