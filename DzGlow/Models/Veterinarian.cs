using TestDZ1Glow.Interfaces;

namespace TestDZ1Glow.Models;

using System;

public class Veterinarian : IVeterinarian
{
    public void TreatAnimal(Animal animal)
    {
        Console.WriteLine("Началось лечение животного {0}.", animal.Name);
        animal.MakeNoise();
        Console.WriteLine("Вылечился");
    }
}
