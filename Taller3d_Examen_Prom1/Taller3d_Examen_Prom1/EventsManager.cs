using System;
using System.Collections.Generic;
using System.Text;

namespace Taller3d_Examen_Prom1
{
    class EventsManager
    {
        List<Player> playableCharacters = new List<Player>();
        List<NpcFriendly> npcs = new List<NpcFriendly>();

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

       

    }
}
