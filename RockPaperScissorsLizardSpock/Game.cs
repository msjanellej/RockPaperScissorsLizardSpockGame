using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    class Game
    {
        //member variables
        public Players players;
        // declare round object

        //constructor
        public Game()
        {
            players = new Players();
            // instantiate round object here.
        }

        // member methods
        
        // Create Display Winner
         
        
        // call RunGame Method: 
        // call Display Rules
        // call Choose Players
        // Call Run Round Method
        // Call Display Winner
        public void DisplayRules()
        {
            Console.WriteLine("Welcome to Rock, Paper, Scissors, Lizard, Spock");
            Console.WriteLine("The Rules Are Simple:");
            Console.WriteLine("First Choose Your Number of Players");
            Console.WriteLine("Each Round Players Will Choose A Gesture.");
            Console.WriteLine("The First Player To Win 2 Rounds Wins");
            Console.WriteLine("Rock Smashes Scissors & Smashes Lizard");
            Console.WriteLine("Paper Covers Rocks & Disproves Spock");
            Console.WriteLine("Lizard Eats Paper & Poisons Spock");
            Console.WriteLine("Spock Vaporizes Rock & Smashes Scissors");
            Console.WriteLine("Good Luck. Live Long & Prosper");
            Console.WriteLine();
        }
        public void RunGame()
        {
            DisplayRules();
            players.ChoosePlayers();
        }
    }
}
