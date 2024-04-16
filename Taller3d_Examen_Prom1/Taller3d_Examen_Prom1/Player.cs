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

        public void UseInstrument()
        {
            Random rand = new Random();
            dex = rand.Next(1, dex);
        }

       
    }
}
