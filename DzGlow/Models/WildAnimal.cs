namespace TestDZ1Glow.Models;

public class WildAnimal : Animal
{
    public override void MakeNoise()
    {
        Console.WriteLine($"Дикое животное {Name} издает звук");
    }
}