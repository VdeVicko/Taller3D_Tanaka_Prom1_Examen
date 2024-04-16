﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Taller3d_Examen_Prom1
{
    class NpcFriendly : Npc
    {
        public NpcFriendly(string name, float life, int strg, int dex, int cha) : base(name, life, strg, dex, cha)
        {

        }

        public override void Interact()
        {
            base.Interact();
            Console.WriteLine("Hey there");
        }

        public void InteractInTeam()
        {
            Console.WriteLine("Im following you");
        }
    }
}
