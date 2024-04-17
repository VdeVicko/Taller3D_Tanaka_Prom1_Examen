using System;
using System.Collections.Generic;
using System.Text;

namespace Taller3d_Examen_Prom1
{
    class Menu
    {
        EventsManager events = new EventsManager();
         public void Execute()
        {
            Console.WriteLine("Welcome player, what do you wanna do?");
            DisplayOptions();
            ExecuteOptions();
        }


        public void DisplayOptions()
        {
            Console.WriteLine("1. Create a player\n" +
                              "2. Create an npc\n" +
                              "3. Create item\n" +
                              "4. List player data" +
                              "5. List npcs data" +
                              "6. Delete a npc" +
                              "7. Delete item" +
                              "8. Give item" +
                              "9. End");
        }

        public void ExecuteOptions()
        {
            switch (int.Parse(Console.ReadLine()))
            {
                case 1:
                    events.CreatePlayer();
                    break;
                case 2:
                    events.CreateNpc();
                    break;
                case 3:
                    events.CreateItem();
                    break;
                case 4:
                    events.playableCharacters[0].ListData();
                    break;
                case 5:
                    foreach (Npc npc in events.npcs)
                    {
                        npc.ListData();
                    }
                    break;
                case 6:
                    events.DeleteNpc();
                    break;
                case 7:
                    events.DeleteItem();
                    break;
                case 8:
                    events.AddItem(events.playableCharacters[0]);
                    break;
                case 9:
                    break;
            }
        }
    }
}
