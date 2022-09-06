namespace Sanitation;

public class Program
{
    public static void Main(string[] args)
    {
        int nPeople, nDispensers;
        bool programDone = false;
        Console.Write("Input number of people: ");
        nPeople = Convert.ToInt32(Console.ReadLine());
        Person[] people = new Person[nPeople];

        for(int i = 0; i < nPeople; i++)
        {
            Console.Write($"Input name of Person {i + 1}: ");
            people[i] = new Person(Console.ReadLine());
        }
        
        Console.Write("Input number of dispensers: ");
        nDispensers = Convert.ToInt32(Console.ReadLine());
        Dispenser[] dispensers = new Dispenser[nDispensers];

        for(int i = 0; i < nDispensers; i++)
        {
            Console.Write($"Input volume of dispenser {i + 1}: ");
            double volume = Convert.ToDouble(Console.ReadLine());
            dispensers[i] = new Dispenser(i + 1, volume);
        }

        do
        {
            Console.Clear();

            for (int i = 0; i < nPeople; i++)
            {
                Console.WriteLine($"Person {i + 1}: {people[i].Name} - Is clean?: {people[i].Hygiene}");
                Console.WriteLine("----------------------------------------");
            }

            for (int i = 0; i < nDispensers; i++)
            {
                Console.WriteLine($"Dispenser {dispensers[i].ID}: Volume: {dispensers[i].Volume}");
                Console.WriteLine("----------------------------------------");
            }

            Console.WriteLine("");
            Console.WriteLine("List of actions:");
            Console.WriteLine("(play) Let someone play outside.");
            Console.WriteLine("(clean) Let someone use the dispenser.");
            Console.WriteLine("(refill) The dispenser will be refilled.");
            Console.WriteLine("(exit) Exit the program.");
            Console.WriteLine("");

            Console.Write("Input: ");
            string input = Console.ReadLine();
            Console.WriteLine("");

            if (input.ToLower() == "play")
            {
                Console.Write("Who will play outside?: ");
                input = Console.ReadLine();
                bool foundName = false;
                for(int i = 0; i < nPeople; i++)
                {
                    if(input.ToLower() == people[i].Name.ToLower())
                    {
                        foundName = true;
                        people[i].Play();
                        Console.ReadLine();
                    }
                }
                if(!foundName)
                {
                    Console.WriteLine("Name not found.");
                    Console.ReadLine();
                }
            }
            else if (input.ToLower() == "clean")
            {
                Console.Write("Who will use the dispenser?: ");
                input = Console.ReadLine();
                bool foundName = false;
                for(int i = 0; i < nPeople; i++)
                {
                    if(input.ToLower() == people[i].Name.ToLower())
                    {
                        foundName = true;
                        if(nDispensers == 1)
                        {
                            people[i].Clean(dispensers[0]);
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.Write("Which dispenser ID?: ");
                            int index = Convert.ToInt32(Console.ReadLine());
                            people[i].Clean(dispensers[index-1]);
                            Console.ReadLine();
                        }
                    }
                }
                if(!foundName)
                {
                    Console.WriteLine("Name not found.");
                    Console.ReadLine();
                }
            }
            else if (input.ToLower() == "refill")
            {
                if(nDispensers == 1)
                {
                    dispensers[0].Refill();
                }
                else
                {
                    Console.Write("Which dispenser ID?: ");
                    int index = Convert.ToInt32(Console.ReadLine());
                    dispensers[index - 1].Refill();
                    Console.ReadLine();
                }
            }
            else if (input.ToLower() == "exit")
            {
                Console.WriteLine("Program terminated.");
                programDone = true;
            }
            else
            {
                Console.WriteLine("Invalid input. Try again.");
                Console.ReadLine();
            }
        } while (!programDone);
    }
}