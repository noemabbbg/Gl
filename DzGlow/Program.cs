using TestDZ1Glow.Models;

namespace TestDZ1Glow;

using System;


class Program
{
    static void Main(string[] args)
    {
        Veterinarian veterinar = new Veterinarian();

        
        Queue<Animal> animals = new Queue<Animal>();
        animals.Enqueue(new PetAnimal { Name = "Кот" });
        animals.Enqueue(new PetAnimal() { Name = "Собака" });
        animals.Enqueue(new PetAnimal() { Name = "Крыса" });
        animals.Enqueue(new WildAnimal { Name = "Лев" });
        animals.Enqueue(new WildAnimal { Name = "Бегемот" });
        animals.Enqueue(new WildAnimal { Name = "Жираф" });

        
        while (animals.Count > 0)
        {
            Animal currentAnimal = animals.Dequeue();
            veterinar.TreatAnimal(currentAnimal);
            Console.WriteLine();
        }
    }
}
