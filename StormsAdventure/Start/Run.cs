﻿using StormsAdventure.Character;
using StormsAdventure.Fighting;
using StormsAdventure.Stuff;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StormsAdventure.Start
{
    public static class Run
    {

        public static void Game_Tick() //For things witch need to tick when the game runs
        {
            Player.Tick_Stamina();
        }

        public static void StartGame() //This method will run all items at game run
        {
            Inventory.Initialize();
            Player.Initialize();
            Enemy.Initialize();
            WeaponSlot.Initialize();
            Lootdrop.Initialize();

            Menu_Start.Menu();
        }
    }
}
