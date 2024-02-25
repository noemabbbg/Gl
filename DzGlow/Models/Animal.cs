namespace TestDZ1Glow.Models;


public abstract class Animal
{
    public string Name { get; set; }
    public int? Age { get; set; }

    public abstract void MakeNoise();
}



