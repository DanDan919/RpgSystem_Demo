﻿using System;
using TravelRPGSystem_1.Characters.Person_Class;
using TravelRPGSystem_1.Routes.Main_Biome;

namespace TravelRPGSystem_1.Routes.Main_Biome
{
    public class Main_Town : Main_Biome
    {
        public Main_Town(Person_entities character) : base(character)
        {
            Name = "Town";
        }

        public  void TriggerEvent()
        {
            Console.WriteLine(" Вы входите в город...");
            Character.RestoreFullStats(); 
            Console.WriteLine(" Все характеристики восстановлены!");
        }
    }
}