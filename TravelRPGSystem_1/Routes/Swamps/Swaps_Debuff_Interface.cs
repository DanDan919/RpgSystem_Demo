using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelRPGSystem_1.Routes.Main_Biome;



    public interface ISlowdownDebuff
    {
        void ApplySlowdown();
    }

    public interface IWeaknessDebuff
    {
        void ApplyWeakness();
    }

    public interface IUniqueSwampEvent
    {
        void TriggerEvent();
    }

