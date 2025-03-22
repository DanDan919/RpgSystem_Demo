using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using TravelRPGSystem_1.Characters.Person_Class;
using TravelRPGSystem_1.Obstacles;
using TravelRPGSystem_1.Routes.Main_Biome;


namespace TravelRPGSystem_1.Routes.Main_Biome
{
    public class Main_Town : Main_Biome
    {
        public Main_Town(Person_entities character) : base(character)
        {
            Name = "Town";
        }

        public  void TriggerBiomeEvent()
        {
            Console.WriteLine("🏙️ Вы входите в город...");

            Tavern_with_buff tavern = new Tavern_with_buff();

            tavern.ApplyBuffs(Character);
        }
    }
}
