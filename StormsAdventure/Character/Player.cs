﻿using System;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using StormsAdventure.Stuff;
using StormsAdventure.Character;
using StormsAdventure.Graphic;

namespace StormsAdventure.Start
{
    public static class Player
    {
        public static string name { get; set; }

        public static int health { get; set; }

        public static int stamina { get; set; }

        private static bool isInitialize;

        public static void Initialize()
        {
            if (isInitialize)
            {
                return;
            }
            else
            {
                name = "Alissa";
                health = 100;
                stamina = 100;
                isInitialize = true;
            }

        }

        public static void Display_Stats()
        {
            Console.Clear();
            Console.WriteLine("Your name are: " + name);
            Beautifier.CoolBar(health, stamina);
        }

        public static void Tick_Stamina()
        {
            stamina = stamina - 10;
        }

        public static void Eat(Items food)
        {

            if (food.Name == "cookie")
            {
                stamina += food.Item_stat;
            }
            else if (food.Name == "apple")
            {
                stamina += food.Item_stat;
            }
            else if (food.Name == "mushroom")
            {
                stamina -= food.Item_stat;
            }
        }



    }


}
