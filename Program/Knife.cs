using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal class Knife : Item
    {
        public override void Activate()
        {
            Console.WriteLine("Cut with a knife");
        }

    }
}
