using System.Security.Cryptography.X509Certificates;

namespace Sanitation;

public class Program
{
    public static void Main(string[] args)
    {
        Person person1 = new Person("Nilo", true);
        Dispenser dispenser1 = new Dispenser(1, 100.0);
    }
}