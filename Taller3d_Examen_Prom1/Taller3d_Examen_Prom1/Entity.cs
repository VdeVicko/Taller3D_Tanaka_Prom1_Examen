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

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                value = name;
            }
        }

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

        public void listItems()
        {
            foreach(Item item in inventory)
            {
                Console.WriteLine(item.name);
            }
        }

        public void AddItem(Item item)
        {
            inventory.Add(item);
        }

        public void ListData()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Life: " + life);
            Console.WriteLine("Strg: " + strg);
            Console.WriteLine("Dex: " + dex);
            Console.WriteLine("Cha: " + cha);
        }

    }

}
