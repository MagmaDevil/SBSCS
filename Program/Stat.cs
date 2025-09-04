using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal class Stat
    {
        private int wisdom;
        private int strength;
        private int dexterity;
        private int intelligence;

        public int Wisdom { set { wisdom = value; } }
        public int Strength { set { strength = value; } }
        public int Dexterity { set { dexterity = value; } }
        public int Intelligence { set { intelligence = value; } }

        public void Describe()
        {
            Console.WriteLine("Wisdom: " + wisdom);
            Console.WriteLine("Strength: " + strength);
            Console.WriteLine("Dexterity: " + dexterity);
            Console.WriteLine("Intelligence: " + intelligence);
        }
    }
}
