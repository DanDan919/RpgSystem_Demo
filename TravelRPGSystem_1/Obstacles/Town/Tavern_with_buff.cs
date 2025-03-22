using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelRPGSystem_1.Events.Event_algorithm;
using TravelRPGSystem_1.Characters.Person_Class;
using TravelRPGSystem_1.Routes.Main_Biome;
using TravelRPGSystem_1.Routes;
using TravelRPGSystem_1.Movement_on_the_map;

namespace TravelRPGSystem_1.Obstacles
{
    public class Tavern_with_buff
    {
        public void ApplyBuffs(Person_entities character)
        {
            character.Health = character.MaxHealth;
            character.Stamina = character.MaxStamina;
            character.Endurance = character.MaxEnergy;
            // запрос чату - int у каждого класса персонажа, должен меняться при проходе через биомы
            // после прохождения этой локации он должен возвращаться к прежнему значению

            Console.WriteLine("🍺 Вы зашли в таверну! Вас полностью вылечили и восстановили силы.");
        }
    }
}