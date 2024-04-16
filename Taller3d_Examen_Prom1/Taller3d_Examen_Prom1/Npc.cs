using System;
using System.Collections.Generic;
using System.Text;

namespace Taller3d_Examen_Prom1
{
    class Npc : Entity
    {
        

        public Npc(string name, float life, int strg, int dex, int cha) : base(name, life, strg, dex, cha)
        {

        }

        public virtual void Interact()
        {
            
        }


    }
}
