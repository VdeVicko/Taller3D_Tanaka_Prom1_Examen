using System;
using System.Collections.Generic;
using System.Text;

namespace Taller3d_Examen_Prom1
{
    class Item
    {
        public float coast { get; set; }
        public string name { get; set; }
        public Item(string name,float cost)
        {

        }

        public virtual void PrintStats()
        {
            Console.WriteLine("Name of the weapon: " + name);
            Console.WriteLine("Costo del arma: " + coast);
        }

    }
}
