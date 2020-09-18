using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    class Human : Players
    {
        //member variables
        int response;

        // constructor
        public Human()
        {

        }

        // member methods
        // Create override Choose Gesture Method for human
        public override void ChooseGesture()
        {
            Console.WriteLine("Please choose from the list below:");
            Console.WriteLine("Choose '0' for rock, '1' for paper, '2' for scissors");
            Console.WriteLine("'3' for lizard, or '4' for Spock");
            Console.WriteLine();
            response = int.Parse(Console.ReadLine());
            switch (response)
            {//update numbers in cw above move to computer class chosengesture instead of response
                case 0:
                    Console.WriteLine("You chose rock");
                    break;
                case 1:
                    Console.WriteLine("You chose paper");
                    break;
                case 2:
                    Console.WriteLine("You chose scissors");
                    break;
                case 3:
                    Console.WriteLine("You chose lizard");
                    break;
                case 4:
                    Console.WriteLine("You chose spock");
                    break;
            }
            ChosenGesture = response;

            
        }
    }
}
