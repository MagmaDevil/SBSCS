using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal class Potion : Item
    {

        public override void Activate()
        {
            Console.WriteLine("stamina recovery");
        }        

    }
}
