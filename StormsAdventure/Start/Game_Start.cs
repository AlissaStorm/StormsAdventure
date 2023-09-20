﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StormsAdventure.Character;
using StormsAdventure.Stuff;
//using StormsAdventure.Levels;

namespace StormsAdventure.Start
{
    public class Game_Start
    {
        
        public void Menu()
        {

            bool state = true;
            
            while (state == true)
            {
                
                Console.Clear();
                Console.WriteLine("Welcome to Storm's RPG game");
                Console.WriteLine("---------------------------");
                Console.WriteLine("1 - Start the game");
                Console.WriteLine("2 - Exit the game");

                string playerChoice = Console.ReadLine();

                if (playerChoice == "1")
                {
                    Console.Clear();
                    state = false;
                    Game_Intro();
                    

                }
                else if (playerChoice == "2")
                {
                    state = false;
                    Console.Clear();
                    Environment.Exit(0);

                }
                else
                {
                    Console.WriteLine("---------------------------");
                    Console.WriteLine("U entered a wrong value plz try agian");
                    Console.Clear();
                }
            }
        }
        

        public void Game_Intro()
        {
            House house = new House();
            Console.WriteLine("The sun poured through my window. Another day had dawned. Storm walks down the stairs");
            Console.WriteLine("Mom: Good morning Storm");
            Console.WriteLine("Storm: Morning Mom");

            Console.WriteLine("Mom: We are in need of bananas for the banana cake. Do you mind going to the grocery store?");
            Console.WriteLine("Pick an answer: ");
            Console.WriteLine("1 - Storm: Sure, i can do that");
            Console.WriteLine("2 - Storm: Nah, actually not");


            bool state = true;

            while (state == true)
            {
                int Playerchoice = Convert.ToInt32(Console.ReadLine());

                if (Playerchoice == 1)
                {
                    Console.WriteLine("Storm: Sure, i can do that");
                    state = false;
                    Console.Clear();
                    house.Start_House();
                    break;
                }
                else if (Playerchoice == 2)
                {
                    Console.WriteLine("Storm: Nah, actually not"); // Need to fix the text, disseapers instantly
                    Console.WriteLine("RIP Alissa Storm");
                    Console.WriteLine("Cause of death: Mom with Shahata");
                    
                    Menu();
                }
                else
                {
                    Console.WriteLine("---------------------------");
                    Console.WriteLine("You entered a wrong value plz try agian");
                    Console.Clear();
                }
            }
                              
        }

    }
}
