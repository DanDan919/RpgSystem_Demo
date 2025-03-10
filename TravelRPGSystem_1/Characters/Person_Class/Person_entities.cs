using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelRPGSystem_1.Routes.Main_Biome;


namespace TravelRPGSystem_1.Characters.Person_Class
{


    public abstract class Person_entities
    {
        public int Health { get; protected set; }
        public double Stamina { get; protected set; }
        public int Endurance { get; protected set; }
        public int Intelligence { get; protected set; }
        public int Speed { get; protected set; }

        protected Person_entities(int health, double stamina, int endurance, int intelligence, int speed)
        {
            Health = health;
            Stamina = stamina;
            Endurance = endurance;
            Intelligence = intelligence;
            Speed = speed;
        }
    }
}