﻿using StormsAdventure.Character;
using StormsAdventure.Fighting;
using StormsAdventure.Graphic;
using StormsAdventure.Start;
using StormsAdventure.Stuff;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace StormsAdventure.Levels
{
    public class Forest
    {
        
        public void Start_Outside()
        {
            Ascii_Art.Ascii_Forest();
            InForest();     
        }

        public static void InForest()
        {
            Ascii_Art.Ascii_Forest();
            Combat combat = new Combat();

            Console.Write("After some time walking from your house. You reach a point where you have two options. You can either take the short cut through the forest");
            Console.WriteLine(" or take the longer way by taking the original walking path ");
            Control.Controls();

            Console.WriteLine("Where would you like to go?");
            Console.WriteLine(" 1 - Through the forest");
            Console.WriteLine(" 2 - The walking path");
            Console.WriteLine(" 3 - "); //Uknown
            

            bool state = true;

            int PlayerChoice = Convert.ToInt32(Console.ReadLine());
          

            while (state)
            {
                if(PlayerChoice == 1) //In the forest. Meeting an enemy
                {               
                    Console.Write("The forest is vast and seemingly endless, with no clear paths or markers to guide your way.");
                    Console.WriteLine("The deeper you venture, the more you feel cut off from the outside world, as if you've entered another dimension entirely.");
                    Console.WriteLine("You move forward slowly, constantly scanning your surroundings. Your senses are on high alert, listening for any unusual sounds or movement.");
                    Console.WriteLine("Your heart beats loudly in your chest, the adrenaline coursing through your veins as you inch closer. You try to control your breathing, taking slow, deliberate breaths to avoid giving away your position.");
                    Console.WriteLine("Finally, you catch a glimpse of movement up ahead. It's them – the enemy");

                    
                    combat.Start_Combat(); 
                    Console.WriteLine("Great Job! You won the battle against the enemy! Here is a gift: Sword");

                    Weapons Sword = new Weapons("Sword", 10);
                    
                    WeaponSlot.SwitchWeapon(Sword);

                    AfterForest();
                    
                    
                }
                else if (PlayerChoice == 2) // Meeting a new character
                {

                    Console.WriteLine("");
                    Console.WriteLine("The path seemed never ending, time seemed to lose its meaning as I walked, and I became lost in the rhythm of my own breath and the cadence of my footsteps.");
                    Console.WriteLine("Until i met a stranger"); 
                   
                    

                }
            }

        }

        public static void AfterForest()
        {
            Ascii_Art.Ascii_Forest();
            Console.WriteLine("As i walked further, I see from a distance a little peak from a mountain. Since when "); // We see a Mountain
            Console.WriteLine(""); // We meet an acquaintance
            Console.WriteLine("Where would you like to go?");

            Control.Controls();

            bool state = true;
            int PlayerChoice =Convert.ToInt32(Console.ReadLine());

            while (state)
            {
                if(PlayerChoice == 1)
                {

                    Mountains.Mountain(); //Jumping over to Mountains class by using Mountain method

                }
                else if (PlayerChoice == 2)
                {
                    //Acquaintance method --> Mountains class
                    Console.WriteLine("With a contented sigh, I continued my journey");
                }






            }



        }



    }
}
