using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using TravelRPGSystem_1.Characters.Person_Class;

namespace TravelRPGSystem_1.Routes.Main_Biome
{

           public class Main_Town : Main_Biome
            {
                public Main_Town(Person_entities character) : base(character)
                {
                    Name = "Swamps";
                }

                public override void ApplyDebuff()
                {
                    // Реализация дебаффов
                }

                public override void TriggerEvent()
                {
                    // Реализация событий
                }
            }
     }    

