using System;
using System.Collections.Generic;
using System.Text;

namespace Taller3d_Examen_Prom1
{
    class Weapon : Item
    {
        float dmg { get; set; }
        public Weapon(string name,float coast) : base(name,coast)
        {

        }


        public override void PrintStats()
        {
            base.PrintStats();
            Console.WriteLine("El daño del arma es: " + dmg);
        }
    }
}
