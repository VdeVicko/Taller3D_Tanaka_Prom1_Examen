using System;
using System.Collections.Generic;
using System.Text;

namespace Taller3d_Examen_Prom1
{
    class Player : Entity
    {

        public Player(string name,float life, int strg, int dex, int cha) : base(name,life, strg,dex,cha )
        {

        }

        public void AddPoints(int point)
        {
            Console.WriteLine("Select the stat");
            Console.WriteLine("1.Strg: " + strg);
            Console.WriteLine("2.Dex: " + dex);
            Console.WriteLine("3.Cha " + cha);
            switch(int.Parse(Console.ReadLine()))
            {
                case 1:
                    strg += point;
                    break;
                case 2:
                    dex += point;
                    break;
                case 3:
                    cha += point;
                    break;
            }
        }

        public void UseInstrument()
        {
            Random rand = new Random();
            dex = rand.Next(1, dex);
        }

       
    }
}
