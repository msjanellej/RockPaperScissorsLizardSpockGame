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
        
        

        public void Welcome()
        {
            Console.WriteLine("Welcome to Rock, Paper, Scissors, Lizard, Spock");
            Console.WriteLine();
        }


        public void DisplayRules()
        {

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
                    Console.WriteLine();
                    Console.WriteLine("You have chosen one player. You will play against the computer.");
                    Console.WriteLine();
                    playerTwo = new Computer();
                    break;
                case "2":
                    Console.WriteLine();
                    Console.WriteLine("You have chosen two players. You will battle each other. ");
                    Console.WriteLine();
                    playerTwo = new Human();
                    break;
                default:
                    Console.WriteLine();
                    Console.WriteLine("You did not make a valid choice.");
                    Console.WriteLine();
                    break;

            }
        }
        public bool DoesGameContinue()
        {
            if (playerOneScore >= 20 || playerTwoScore >= 20)
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
            if(playerOne.ChosenGesture == "rock" && playerTwo.ChosenGesture == "paper")
            {
                playerTwoScore += 10;
                Console.WriteLine();
                Console.WriteLine("Paper covers rock");
                Console.WriteLine("Player Two Wins This Round");
                Console.WriteLine();

            }
            else if (playerOne.ChosenGesture == "rock" && playerTwo.ChosenGesture == "Spock")
            {
                playerTwoScore += 10;
                Console.WriteLine();
                Console.WriteLine("Spock vaporizes rock");
                Console.WriteLine("Player Two Wins This Round");
                Console.WriteLine();
            }
            else if (playerOne.ChosenGesture == "rock" && playerTwo.ChosenGesture == "scissors")
            {
                playerOneScore += 10;
                Console.WriteLine();
                Console.WriteLine("Rock smashes scissors");
                Console.WriteLine("Player One Wins this Round");
                Console.WriteLine();

            }
            else if (playerOne.ChosenGesture == "rock"&& playerTwo.ChosenGesture == "lizard")
            {
                playerOneScore += 10;
                Console.WriteLine();
                Console.WriteLine("Rock smashes lizard");
                Console.WriteLine("player One Wins This Round");
                Console.WriteLine();
            }
            else if (playerOne.ChosenGesture == "paper" && playerTwo.ChosenGesture == "rock")
            {
                playerOneScore += 10;
                Console.WriteLine();
                Console.WriteLine("Paper covers rock");
                Console.WriteLine("Player One Wins This Round");
                Console.WriteLine();
            }
            else if (playerOne.ChosenGesture == "paper"&& playerTwo.ChosenGesture == "Spock")
            {
                playerOneScore += 10;
                Console.WriteLine();
                Console.WriteLine("Paper disproves Spock");
                Console.WriteLine("Player One Wins This Round");
                Console.WriteLine();
            }
            else if (playerOne.ChosenGesture == "paper" && playerTwo.ChosenGesture == "lizard")
            {
                playerTwoScore += 10;
                Console.WriteLine();
                Console.WriteLine("Lizard eats paper");
                Console.WriteLine("Player Two Wins This Round");
                Console.WriteLine();
            }
            else if (playerOne.ChosenGesture == "paper" && playerTwo.ChosenGesture == "scissors")
            {
                playerTwoScore += 10;
                Console.WriteLine();
                Console.WriteLine("Scissors cut paper");
                Console.WriteLine("Player Two Wins This Round");
                Console.WriteLine();
            }
            else if (playerOne.ChosenGesture == "scissors" && playerTwo.ChosenGesture == "rock")
            {
                playerTwoScore += 10;
                Console.WriteLine();
                Console.WriteLine("Rock crushes scissors");
                Console.WriteLine("Player Two Wins This Round");
                Console.WriteLine();
            }
            else if (playerOne.ChosenGesture == "scissors" && playerTwo.ChosenGesture == "paper")
            {
                playerOneScore += 10;
                Console.WriteLine();
                Console.WriteLine("Scissors cut paper");
                Console.WriteLine("Player One Wins This Round");
                Console.WriteLine();
            }
            else if (playerOne.ChosenGesture == "scissors" && playerTwo.ChosenGesture == "Spock")
            {
                playerTwoScore += 10;
                Console.WriteLine();
                Console.WriteLine("Spock smashes Scissors");
                Console.WriteLine("Player Two Wins This Round");
                Console.WriteLine();
            }
            else if (playerOne.ChosenGesture == "scissors" && playerTwo.ChosenGesture == "lizard")
            {
                playerOneScore += 10;
                Console.WriteLine();
                Console.WriteLine("Scissors decapitate lizard");
                Console.WriteLine("Player One Wins This Round");
                Console.WriteLine();
            }
            else if (playerOne.ChosenGesture == "lizard" && playerTwo.ChosenGesture == "Spock")
            {
                playerOneScore += 10;
                Console.WriteLine();
                Console.WriteLine("Lizard poisons Spock");
                Console.WriteLine("Player One Wins This Round");
                Console.WriteLine();
            }
            else if (playerOne.ChosenGesture == "lizard" && playerTwo.ChosenGesture == "paper")
            {
                playerOneScore += 10;
                Console.WriteLine();
                Console.WriteLine("Lizard eats paper");
                Console.WriteLine("Player One Wins This Round");
                Console.WriteLine();
            }
            else if (playerOne.ChosenGesture == "lizard" && playerTwo.ChosenGesture == "rock")
            {
                playerTwoScore += 10;
                Console.WriteLine();
                Console.WriteLine("Rock crushes lizard");
                Console.WriteLine("Player Two Wins This Round");
                Console.WriteLine();
            }
            else if (playerOne.ChosenGesture == "lizard" && playerTwo.ChosenGesture == "scissors")
            {
                playerTwoScore += 10;
                Console.WriteLine();
                Console.WriteLine("Scissors decapitate lizard");
                Console.WriteLine("Player Two Wins This Round");
                Console.WriteLine();
            }
            else if (playerOne.ChosenGesture == "Spock" && playerTwo.ChosenGesture == "paper")
            {
                playerTwoScore += 10;
                Console.WriteLine();
                Console.WriteLine("Paper disproves Spock");
                Console.WriteLine("Player Two Wins This Round");
                Console.WriteLine();
            }
            else if (playerOne.ChosenGesture == "Spock" && playerTwo.ChosenGesture == "lizard")
            {
                playerTwoScore += 10;
                Console.WriteLine();
                Console.WriteLine("Lizard poisons Spock");
                Console.WriteLine("Player Two Wins This Round");
                Console.WriteLine();
            }
            else if (playerOne.ChosenGesture == "Spock" && playerTwo.ChosenGesture == "rock")
            {
                playerOneScore += 10;
                Console.WriteLine();
                Console.WriteLine("Spock vaporizes rock");
                Console.WriteLine("Player One Wins This Round");
                Console.WriteLine();
            }
            else if (playerOne.ChosenGesture == "Spock" && playerTwo.ChosenGesture == "scissors")
            {
                playerOneScore += 10;
                Console.WriteLine();
                Console.WriteLine("Spock crushes scissors");
                Console.WriteLine("Player One Wins This Round");
                Console.WriteLine();
            }
            else 
            {
                Console.WriteLine();
                Console.WriteLine("This Round Was a tie");
                Console.WriteLine();
            }
          
           


        }
        public void DisplayWinner()
        {
            if (playerOneScore == 20)
            {
                Console.WriteLine();
                Console.WriteLine("Player One is victorious!!!");
            }
            if (playerTwoScore == 20)
            {
                Console.WriteLine();
                Console.WriteLine("Player Two is victorious!!!");
            }
        }


        public void RunGame()
        {
            Welcome();
            DisplayRules();
            ChooseGameType();
            while (DoesGameContinue())
            {
                Console.Clear();
                DisplayRules();
                playerOne.ChooseGesture();
               
                Console.WriteLine();
                playerTwo.ChooseGesture();
                Console.WriteLine();
                CompareChoices();

            }
            DisplayWinner();

        }
    }
}
