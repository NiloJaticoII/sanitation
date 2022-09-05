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

        public Person(string name, bool hygiene)
        {
            this.name = name;
            this.hygiene = hygiene;
        }

        public bool Hygiene
        {
            get { return this.hygiene; }
            set { this.hygiene = value; }
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public void Play()
        {
            this.hygiene = false;
        }

        public void Clean(Dispenser dispenser)
        {
            dispenser.Dispense(this);
        }
    }
}
