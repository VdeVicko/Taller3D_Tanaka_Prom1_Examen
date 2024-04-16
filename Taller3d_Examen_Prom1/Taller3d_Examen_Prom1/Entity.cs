using System;
using System.Collections.Generic;
using System.Text;

namespace Taller3d_Examen_Prom1
{
    class Entity
    {
        protected float life { get; set; }

        protected string name { get; set; }

        public Entity(string name, float life)
        {
            this.life = life;
            this.name = name;
        }

    }

}
