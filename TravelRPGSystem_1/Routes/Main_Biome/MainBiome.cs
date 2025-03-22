using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelRPGSystem_1.Characters.Person_Class;



namespace TravelRPGSystem_1.Routes.Main_Biome
{
    public abstract class Main_Biome
    {
        protected Person_entities Character; 
        public string Name { get; protected set; }

        protected Main_Biome(Person_entities character)
        {
            Character = character;
        }
       
        public virtual void ApplyDebuff()
        {
            Console.WriteLine($"⚠️ Дебафф в биоме {Name} применён!");
        }
        public virtual void TriggerEvent()
        {
            Console.WriteLine($"🎲 Случайное событие в биоме {Name} произошло!");
        }

    }
}