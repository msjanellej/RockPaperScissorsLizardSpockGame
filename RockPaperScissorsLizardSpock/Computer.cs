﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    class Computer : Players
    {
        //member variables
        public Random rand;

        
        


        // Constructor
        public Computer()
        {
            rand = new Random();
            
            
        }

        // member methods
        // create override ChoosGesture method
        public override void ChooseGesture()
        {
            ChosenGesture =  rand.Next(gestures.Count);
            switch (ChosenGesture)
            {
                case 0:
                    Console.WriteLine("Computer chose rock");
                    break;
                case 1:
                    Console.WriteLine("Computer chose paper");
                    break;
                case 2:
                    Console.WriteLine("Computer chose scissors");
                    break;
                case 3:
                    Console.WriteLine("Computer chose lizard");
                    break;
                case 4:
                    Console.WriteLine("Computer chose spock");
                    break;
            }

        }



    }
}
