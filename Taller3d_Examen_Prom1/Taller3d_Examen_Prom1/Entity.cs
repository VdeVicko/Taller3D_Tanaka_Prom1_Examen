using System;
using System.Collections.Generic;
using System.Text;

namespace Taller3d_Examen_Prom1
{
    class Entity
    {
        public List<Item> inventory = new List<Item>();
        protected float life { get; set; }

        protected string name { get; set; }

        protected int strg { get; set; }

        protected int dex { get; set; }

        protected int cha { get; set; }

        public Entity(string name,float life, int strg,int dex, int cha )
        {
            this.life = life;
            this.name = name;
            this.strg = strg;
            this.dex = dex;
            this.cha = cha;
        }

    }

}
