using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    class Gestures
    {
        //member variables
        public Gestures rock;
        public Gestures paper;
        public Gestures scissors;
        public Gestures lizard;
        public Gestures spock;


        //constructor
        public Gestures()
        {
            rock = new Gestures();
            paper = new Gestures();
            scissors = new Gestures();
            lizard = new Gestures();
            spock = new Gestures();


        }

       // membermethods
       // public void RockBeats()
       // {
       //     if (Game.playerOne.chosenGesture == rock && scissors || lizard)
       //     {
       //         Game.playerOneScore += 10;
       //     }
       // }



    }
        
}
