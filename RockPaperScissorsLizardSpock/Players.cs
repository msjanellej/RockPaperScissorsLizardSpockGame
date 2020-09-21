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
        public string chosenGesture;
        public List<string> gestures; 

        //constructor
        public Players()
        {
            score = 0;
            gestures = new List<string>() { "rock", "paper", "scissors", "lizard", "Spock" };

          
            

        }

        //member methods
        public abstract void ChooseGesture();

        
        
       
    }
}
