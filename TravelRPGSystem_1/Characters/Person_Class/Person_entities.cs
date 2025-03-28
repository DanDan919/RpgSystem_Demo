using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelRPGSystem_1.Routes.Main_Biome;
using TravelRPGSystem_1.Obstacles;
using System.Xml.Linq;



namespace TravelRPGSystem_1.Characters.Person_Class
{
    public abstract class Person_entities
    {
        public string Name { get; private set; }
        public int Health { get; set; }
        public int Stamina { get;  set; }
        public int Endurance { get; set; }
        public int Intelligence { get; set; } 
        public int Speed { get; set; }

        public int MaxHealth { get; protected set; }
        public int MaxStamina { get; protected set; }
        public int MaxEndurance { get; protected set; }
        public int MaxIntelligence { get; protected set; }


        
        public void RestoreFullStats()
        {
            Health = MaxHealth;
            Stamina = MaxStamina;
            Endurance = MaxEndurance;
            Intelligence = MaxIntelligence;


            Console.WriteLine("🏡 Вы отдохнули и восстановили все характеристики!");
            Console.WriteLine($"❤️ HP: {Health}, ⚡ Стамина: {Stamina}, 🛡️ Выносливость: {Endurance}, 🧠 Интеллект: {Intelligence}, 🏃 Скорость: {Speed}");
        }



        public Person_entities(int health, int stamina, int endurance, int intelligence, int speed, string name)
        {
            Name = name;
            Health = health;
            Stamina = stamina;
            Endurance = endurance;
            Intelligence = intelligence;
            Speed = speed;
        }

        
        public void ApplyBuff(int healthBuff, int staminaBuff, int enduranceBuff, int intelligenceBuff, int speedBuff)
        {
            Health += healthBuff;
            Stamina += staminaBuff;
            Endurance += enduranceBuff;
            Intelligence += intelligenceBuff;
            Speed += speedBuff;

            Console.WriteLine($"🔹 Бафф применён: +{healthBuff} HP, +{staminaBuff} Stamina, +{enduranceBuff} Endurance, +{intelligenceBuff} Intelligence, +{speedBuff} Speed");
        }

        
        public void ApplyDebuff(int healthDebuff, int staminaDebuff, int enduranceDebuff, int intelligenceDebuff, int speedDebuff)
        {
            Health -= healthDebuff;
            Stamina -= staminaDebuff;
            Endurance -= enduranceDebuff;
            Intelligence -= intelligenceDebuff;
            Speed -= speedDebuff;

            Console.WriteLine($"⚠️ Дебафф получен: -{healthDebuff} HP, -{staminaDebuff} Stamina, -{enduranceDebuff} Endurance, -{intelligenceDebuff} Intelligence, -{speedDebuff} Speed");
        }
        public void ModifySpeed(int amount)
        {
            Speed += amount;
            if (Speed < 0) Speed = 0; 
        }
        public void PrintStats()
        {
            Console.WriteLine($"📊 {Name}: HP: {Health}, Stamina: {Stamina}, Endurance: {Endurance}, Intelligence: {Intelligence}, Speed: {Speed}");
        }
    }
    
}
    
 
