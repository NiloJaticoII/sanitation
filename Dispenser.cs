using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sanitation
{
    public class Dispenser
    {
        private int id;
        private double volume;
        private double maxVolume;
        public Dispenser(int id, double volume)
        {
            this.id = id;
            this.volume = volume;
            this.maxVolume = volume;
        }

        public int ID
        {
            get { return this.id; }
        }

        public double Volume 
        { 
            get { return this.volume; } 
        }

        public double MaxVolume
        {
            get { return this.maxVolume; }
        }

        public void Refill()
        {
            this.volume = this.maxVolume;
            Console.WriteLine($"Dispenser {this.id} is refilled.");
        }

        public bool CheckEmpty()
        {
            return this.volume == 0;
        }

        public void Dispense(Person person)
        {
            if(CheckEmpty())
            {
                Console.WriteLine("Dispenser is unavailable.");
            }
            else
            {
                this.volume = this.volume - (this.maxVolume / 10);
                Console.WriteLine($"Dispenser {this.id} dispensed.");
                person.Hygiene = true;
            }
        }
    }
}
