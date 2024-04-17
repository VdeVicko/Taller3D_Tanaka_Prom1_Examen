using System;
using System.Collections.Generic;
using System.Text;

namespace Taller3d_Examen_Prom1
{
    class EventsManager
    {
        public List<Player> playableCharacters = new List<Player>();
        public List<NpcFriendly> npcs = new List<NpcFriendly>();
        public List<Item> listItems = new List<Item>();

        public void CreatePlayer()
        {
            int points = 10;
            Player player = new Player("null",0,0,0,0);
            Console.WriteLine("Your character has 3 stats,they help you to succes the events, you can add points to your stats");
            do
            {
                player.AddPoints(points);

            }while (points >= 0);

            Console.WriteLine("Whats the name of the character");
            player.Name = Console.ReadLine();
            playableCharacters.Add(player);
        }

        public void CreateNpc()
        {
            Random rand = new Random();
            NpcFriendly npc = new NpcFriendly("Random",rand.Next(20), rand.Next(20), rand.Next(20), rand.Next(20));
            Console.WriteLine("Whats the name of the Npc?");
            npc.Name = Console.ReadLine();
            npcs.Add(npc);
        }

        public void ListNpcs()
        {
            foreach(NpcFriendly npc in npcs)
            {
                Console.WriteLine(npcs.IndexOf(npc)+"."+npc.Name);
            }
        }

        public void DeleteNpc()
        {
            Console.WriteLine("Tell me the number who need to leave");
            npcs.RemoveAt(int.Parse(Console.ReadLine()));
        }

        public void CreateItem()
        {
            Item item = new Item("Item", 0);
            Console.WriteLine("What item is?");
            item.name = Console.ReadLine();
            Console.WriteLine("How much teh item cost?");
            item.coast = float.Parse(Console.ReadLine());
            listItems.Add(item);
        }

        public void AddItem(Player player)
        {
            Console.WriteLine("What item do you want to select?");
            Item item = listItems[int.Parse(Console.ReadLine())];
            Console.WriteLine("Who do you wanna give the item? \n 1.Player \n 2.Npc");
            switch(int.Parse(Console.ReadLine()))
            {
                case 1:
                    player.AddItem(item);
                    break;
                case 2:
                    Console.WriteLine("Who do you wanna give the item?");
                    ListNpcs();
                    npcs[int.Parse(Console.ReadLine())].AddItem(item);
                    break;
            }

            
        }
        public void DeleteItem()
        {
            Console.WriteLine("What item do you want to delete?");
            foreach(Item item in listItems)
            {
                Console.WriteLine(listItems.IndexOf(item) + ". " + item.name);
            }
            listItems.RemoveAt(int.Parse(Console.ReadLine()));
        }

       

    }
}
