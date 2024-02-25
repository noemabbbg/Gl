namespace TestDZ1Glow.Models;

public class PetAnimal : Animal
{
    public override void MakeNoise()
    {
        Console.WriteLine($"Домашнее животное {Name} издает звук ");
    }
}