﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using StormsAdventure.Character;
using StormsAdventure.Start;
using StormsAdventure.Stuff;

namespace StormsAdventure.Fighting
{
    public class Combat
    {

        public void Start_Combat()
        {
            int i = 0;
            
            Creatures currentCreature = Enemy.Enemy_Pick();

            bool game_State = true;

            Console.WriteLine("The combat starts");
            Console.WriteLine("You are up aginst a: " + currentCreature.Name + " Good luck");


            while(game_State == true)
            {
                if (Player.health <= 1)
                {
                    if (currentCreature.Enemy_Health <= 1)
                    {


                        Console.WriteLine("You attack fitst with: " + WeaponSlot.DisplayName() + "And you deal: " + WeaponSlot.DisplayStat());
                        currentCreature.Enemy_Health -= WeaponSlot.DisplayStat();

                        Console.WriteLine("The enemy attacks you back with: " + currentCreature.Attack_Value + " Damage");
                        Player.health -= currentCreature.Attack_Value;

                        Console.WriteLine("This is round: " + i);

                        i++;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("You won the combat stupid :)");
                        Inventory.AddToInventory(Lootdrop.GetLoot());
                        game_State =  false;
                    }

                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("You have died");
                    Console.WriteLine("What a noob");
                    game_State = false; //If loosing the battle do we restart?
                }
            }

        }




    }
}
