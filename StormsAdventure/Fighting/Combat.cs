﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using StormsAdventure.Character;
using StormsAdventure.Start;

namespace StormsAdventure.Fighting
{
    public class Combat
    {

        public void Start_Combat()
        {
            EnemyController enemyController = new EnemyController();
            Enemy enemy;
            enemy = enemyController.Enemy_Pick();
            Console.WriteLine(enemy.Name);

            bool game_State = true;

            Console.WriteLine("The combat starts");
            Console.WriteLine("You are up aginst a: " + enemy.Name + " Good luck");

            while(game_State == true)
            {
                if (Player.health <= 1)
                {
                    if (enemy.Enemy_Health <= 1)
                    {













                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("You won the combat stupid :)");
                        game_State =  false;
                    }

                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("You have died");
                    Console.WriteLine("What a noob");
                    game_State = false;
                }
            }

        }




    }
}
