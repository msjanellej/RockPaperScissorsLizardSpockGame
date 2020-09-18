using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    abstract class Players
    {
        //member variables
        public int score;
        public int ChosenGesture;
        public List<string> gestures; 

        //constructor
        public Players()
        {
            score = 0;
            gestures = new List<string>() { "rock", "paper", "scissors", "lizard", "Spock" };

          
            

        }
        public abstract void ChooseGesture();

        // member methods
        // 
         
        // Choose Gesture Option here. Can override in the computer child class
        // perhaps choose gesture is abstract method. public abstract void ChooseGesture();
       
    }
}
