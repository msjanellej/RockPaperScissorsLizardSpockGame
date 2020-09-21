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
        string response;
        bool condition;

        // constructor
        public Human()
        {

        }

        // member methods
        
        public override void ChooseGesture()
        {
            condition = true;      
            while (condition)
            {
                Console.WriteLine("Please choose from the list below:");
                Console.WriteLine("'rock', 'paper', 'scissors', 'lizard', or 'Spock'");
                Console.WriteLine();
                response = Console.ReadLine();
                Console.WriteLine();
                switch (response)
                {
                    case "rock":
                        Console.WriteLine("You chose rock");

                        condition = false;
                        break;
                    case "paper":
                        Console.WriteLine("You chose paper");
                        condition = false;
                        break;
                    case "scissors":
                        Console.WriteLine("You chose scissors");
                        condition = false;
                        break;
                    case "lizard":
                        Console.WriteLine("You chose lizard");
                        condition = false;
                        break;
                    case "Spock":
                        Console.WriteLine("You chose Spock");
                        condition = false;
                        break;
                    default:
                        Console.WriteLine("The choice you made was not valid.");
                        Console.WriteLine();
                        break;
                }
            }
            chosenGesture = response; 
        }
    }
}
