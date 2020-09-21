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
        bool condition;
        

        //constructor
        public Game()
        {
            playerOne = new Human();
            
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
            condition = true;
            while (condition)
            {
                Console.WriteLine("Please Choose The Number of Players");
                Console.WriteLine("Type '1' for One Player. Type '2' for Two Players");
                string numberOfPlayers = Console.ReadLine();
                switch (numberOfPlayers)
                {
                    case "1":
                        Console.WriteLine();
                        Console.WriteLine("You have chosen one player. You will play against the computer.");
                        Console.WriteLine();
                        playerTwo = new Computer();
                        condition = false;
                        break;
                    case "2":
                        Console.WriteLine();
                        Console.WriteLine("You have chosen two players. You will battle each other. ");
                        Console.WriteLine();
                        playerTwo = new Human();
                        condition = false;
                        break;
                    default:
                        Console.WriteLine();
                        Console.WriteLine("You did not make a valid choice.");
                        Console.WriteLine();
                        condition = true;
                        break;

                }

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
            if(playerOne.chosenGesture == "rock" && playerTwo.chosenGesture == "paper")
            {
                playerTwoScore += 10;
                Console.WriteLine();
                Console.WriteLine("Paper covers rock");
                Console.WriteLine();
                Console.WriteLine("Player Two Wins This Round");
                Console.WriteLine();

            }
            else if (playerOne.chosenGesture == "rock" && playerTwo.chosenGesture == "Spock")
            {
                playerTwoScore += 10;
                Console.WriteLine();
                Console.WriteLine("Spock vaporizes rock");
                Console.WriteLine();
                Console.WriteLine("Player Two Wins This Round");
                Console.WriteLine();
            }
            else if (playerOne.chosenGesture == "rock" && playerTwo.chosenGesture == "scissors")
            {
                playerOneScore += 10;
                Console.WriteLine();
                Console.WriteLine("Rock smashes scissors");
                Console.WriteLine();
                Console.WriteLine("Player One Wins this Round");
                Console.WriteLine();

            }
            else if (playerOne.chosenGesture == "rock"&& playerTwo.chosenGesture == "lizard")
            {
                playerOneScore += 10;
                Console.WriteLine();
                Console.WriteLine("Rock smashes lizard");
                Console.WriteLine();
                Console.WriteLine("player One Wins This Round");
                Console.WriteLine();
            }
            else if (playerOne.chosenGesture == "paper" && playerTwo.chosenGesture == "rock")
            {
                playerOneScore += 10;
                Console.WriteLine();
                Console.WriteLine("Paper covers rock");
                Console.WriteLine();
                Console.WriteLine("Player One Wins This Round");
                Console.WriteLine();
            }
            else if (playerOne.chosenGesture == "paper"&& playerTwo.chosenGesture == "Spock")
            {
                playerOneScore += 10;
                Console.WriteLine();
                Console.WriteLine("Paper disproves Spock");
                Console.WriteLine();
                Console.WriteLine("Player One Wins This Round");
                Console.WriteLine();
            }
            else if (playerOne.chosenGesture == "paper" && playerTwo.chosenGesture == "lizard")
            {
                playerTwoScore += 10;
                Console.WriteLine();
                Console.WriteLine("Lizard eats paper");
                Console.WriteLine();
                Console.WriteLine("Player Two Wins This Round");
                Console.WriteLine();
            }
            else if (playerOne.chosenGesture == "paper" && playerTwo.chosenGesture == "scissors")
            {
                playerTwoScore += 10;
                Console.WriteLine();
                Console.WriteLine("Scissors cut paper");
                Console.WriteLine();
                Console.WriteLine("Player Two Wins This Round");
                Console.WriteLine();
            }
            else if (playerOne.chosenGesture == "scissors" && playerTwo.chosenGesture == "rock")
            {
                playerTwoScore += 10;
                Console.WriteLine();
                Console.WriteLine("Rock crushes scissors");
                Console.WriteLine();
                Console.WriteLine("Player Two Wins This Round");
                Console.WriteLine();
            }
            else if (playerOne.chosenGesture == "scissors" && playerTwo.chosenGesture == "paper")
            {
                playerOneScore += 10;
                Console.WriteLine();
                Console.WriteLine("Scissors cut paper");
                Console.WriteLine();
                Console.WriteLine("Player One Wins This Round");
                Console.WriteLine();
            }
            else if (playerOne.chosenGesture == "scissors" && playerTwo.chosenGesture == "Spock")
            {
                playerTwoScore += 10;
                Console.WriteLine();
                Console.WriteLine("Spock smashes Scissors");
                Console.WriteLine();
                Console.WriteLine("Player Two Wins This Round");
                Console.WriteLine();
            }
            else if (playerOne.chosenGesture == "scissors" && playerTwo.chosenGesture == "lizard")
            {
                playerOneScore += 10;
                Console.WriteLine();
                Console.WriteLine("Scissors decapitate lizard");
                Console.WriteLine();
                Console.WriteLine("Player One Wins This Round");
                Console.WriteLine();
            }
            else if (playerOne.chosenGesture == "lizard" && playerTwo.chosenGesture == "Spock")
            {
                playerOneScore += 10;
                Console.WriteLine();
                Console.WriteLine("Lizard poisons Spock");
                Console.WriteLine();
                Console.WriteLine("Player One Wins This Round");
                Console.WriteLine();
            }
            else if (playerOne.chosenGesture == "lizard" && playerTwo.chosenGesture == "paper")
            {
                playerOneScore += 10;
                Console.WriteLine();
                Console.WriteLine("Lizard eats paper");
                Console.WriteLine();
                Console.WriteLine("Player One Wins This Round");
                Console.WriteLine();
            }
            else if (playerOne.chosenGesture == "lizard" && playerTwo.chosenGesture == "rock")
            {
                playerTwoScore += 10;
                Console.WriteLine();
                Console.WriteLine("Rock crushes lizard");
                Console.WriteLine();
                Console.WriteLine("Player Two Wins This Round");
                Console.WriteLine();
            }
            else if (playerOne.chosenGesture == "lizard" && playerTwo.chosenGesture == "scissors")
            {
                playerTwoScore += 10;
                Console.WriteLine();
                Console.WriteLine("Scissors decapitate lizard");
                Console.WriteLine();
                Console.WriteLine("Player Two Wins This Round");
                Console.WriteLine();
            }
            else if (playerOne.chosenGesture == "Spock" && playerTwo.chosenGesture == "paper")
            {
                playerTwoScore += 10;
                Console.WriteLine();
                Console.WriteLine("Paper disproves Spock");
                Console.WriteLine();
                Console.WriteLine("Player Two Wins This Round");
                Console.WriteLine();
            }
            else if (playerOne.chosenGesture == "Spock" && playerTwo.chosenGesture == "lizard")
            {
                playerTwoScore += 10;
                Console.WriteLine();
                Console.WriteLine("Lizard poisons Spock");
                Console.WriteLine();
                Console.WriteLine("Player Two Wins This Round");
                Console.WriteLine();
            }
            else if (playerOne.chosenGesture == "Spock" && playerTwo.chosenGesture == "rock")
            {
                playerOneScore += 10;
                Console.WriteLine();
                Console.WriteLine("Spock vaporizes rock");
                Console.WriteLine();
                Console.WriteLine("Player One Wins This Round");
                Console.WriteLine();
            }
            else if (playerOne.chosenGesture == "Spock" && playerTwo.chosenGesture == "scissors")
            {
                playerOneScore += 10;
                Console.WriteLine();
                Console.WriteLine("Spock crushes scissors");
                Console.WriteLine();
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
