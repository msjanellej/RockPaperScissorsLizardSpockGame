using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    class Game
    {
        //member variables
        public Players playerOne;
        public Players playerTwo;
        public int playerOneScore;
        public int playerTwoScore;
        // declare round object

        //constructor
        public Game()
        {
            playerOne = new Human();
            // instantiate round object here.
        }

        // member methods
        // Method to choose player 2 type - human or computer.
        // Create Display Winner


        // call RunGame Method: [x]
        // call Display Rules [x]
        // call Choose Players [x]
        
        // (Run Round Method:
        // Call Choose Gesture [x]
        // Call compare Gestures
        // Call award points)
        // call check for winner of game if met display winner if not repeat round.
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
        public void ChooseGameType() //This needs validation
        {
            Console.WriteLine("Please Choose The Number of Players");
            Console.WriteLine("Type '1' for One Player. Choose '2' for Two Players");
            string numberOfPlayers = Console.ReadLine();
            switch (numberOfPlayers)
            {
                case "1":
                    Console.WriteLine("You have chosen one player. You will play against the computer.");
                    playerTwo = new Computer();
                    break;
                case "2":
                    Console.WriteLine("You have chosen two players. You will battle each other. ");
                    playerTwo = new Human();
                    break;
                default:
                    Console.WriteLine("You did not make a valid choice.");
                    break;

            }
        }
        public bool DoesGameContinue() 
        {
            if(playerOneScore >= 20 || playerTwoScore >= 20)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public void CompareChoices()
        {
            //players tie 
            if (playerOne.ChosenGesture == playerTwo.ChosenGesture)
            {
                Console.WriteLine("This Round Was a tie");
            }
            if (playerOne.ChosenGesture > playerTwo.ChosenGesture)
            {
                playerOneScore += 10;
                Console.WriteLine("Player one wins this round!");
            }
            else
            {
                playerTwoScore += 10;
                Console.WriteLine("Player two wins this round");
            }
            // player one wins
            //player two wins
            //assign point to whomever wins round. 
            
        }
        
        
        public void RunGame()
        {
            DisplayRules();
            ChooseGameType();
            while (DoesGameContinue())
            {
                playerOne.ChooseGesture();
                playerTwo.ChooseGesture();
                CompareChoices();

            }
            
        }
    }
}
