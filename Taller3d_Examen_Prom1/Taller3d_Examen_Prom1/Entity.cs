using System;
using System.Collections.Generic;
using System.Text;

namespace Taller3d_Examen_Prom1
{
    class Entity
    {
        protected float life { get; set; }

        protected string name { get; set; }

        protected float strg { get; set; }

        protected float dex { get; set; }

        protected float cha { get; set; }

        public Entity(string name,float life, float strg,float dex, float cha )
        {
            this.life = life;
            this.name = name;
            this.strg = strg;
            this.dex = dex;
            this.cha = cha;
        }

    }

}
