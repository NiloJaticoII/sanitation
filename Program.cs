using System.Security.Cryptography.X509Certificates;

namespace Sanitation;

public class Program
{
    public static void Main(string[] args)
    {
        Person person1 = new Person("Nilo");
        Dispenser dispenser1 = new Dispenser(1, 100.0);

        Console.WriteLine($"Hello, my name is {person1.Name}.");
        Console.WriteLine($"Is {person1.Name} clean?: {person1.Hygiene}");

        Console.WriteLine($"Dispenser {dispenser1.ID} is now available.");
        Console.WriteLine($"Dispenser {dispenser1.ID} has {dispenser1.Volume} volume.");

        Console.WriteLine($"{person1.Name} will play outside.");
        person1.Play();
        
        Console.WriteLine($"Is {person1.Name} clean?: {person1.Hygiene}");

        Console.WriteLine($"Time to use the dispenser.");
        person1.Clean(dispenser1);

        Console.WriteLine($"Is {person1.Name} clean?: {person1.Hygiene}");
        Console.WriteLine($"Dispenser {dispenser1.ID} has {dispenser1.Volume} volume.");

    }
}