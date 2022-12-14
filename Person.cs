using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sanitation
{
    public class Person
    {
        private string name;
        private bool hygiene;

        public Person(string name)
        {
            this.name = name;
            this.hygiene = true;
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public bool Hygiene
        {
            get { return this.hygiene; }
            set { this.hygiene = value; }
        }

        public void Play()
        {
            Console.WriteLine($"{this.name} is playing outside.");
            this.hygiene = false;
        }

        public void Clean(Dispenser dispenser)
        {
            Console.WriteLine($"{this.name} is using the sanitation dispenser.");
            dispenser.Dispense(this);
        }
    }
}
