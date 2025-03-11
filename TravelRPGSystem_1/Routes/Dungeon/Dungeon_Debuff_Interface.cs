using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelRPGSystem_1.Characters.Person_Class;

namespace TravelRPGSystem_1.Routes.Dungeon
{
    public interface IDungeonDebuff
    {
        void ApplyDungeonDebuff(Person_entities character);
    }
}
