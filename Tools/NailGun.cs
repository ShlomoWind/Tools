using System;

public class NailGun : Tool
{
    public NailGun (int weight) : base("NailGun", weight)
    {
    }
    public override void Describe()
    {
        Console.WriteLine($"\ntool: {this.name} \ndescribe: is an electric, pneumatic, or cordless tool used to quickly and forcefully drive nails into surfaces.\nweight: {this.weight}");
    }
    public override void Use()
    {
        Console.WriteLine("use: Wood construction work");
    }
}