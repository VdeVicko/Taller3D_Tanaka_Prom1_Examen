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


        public override void PrintStats()
        {
            base.PrintStats();
            Console.WriteLine("")
        }

    }
}
