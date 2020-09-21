using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    class Comparative
    {
        //member variables
        public int playerOneScore;
        public int playerTwoScore;



        //constructor
        public Comparative()
        {
            playerOneScore = 0;
            playerTwoScore = 0;


        }

        // membermethods



        public void CompareChoices(Players playerOne, Players playerTwo, int playerOneScore, int playerTwoScore)
        {
            if (playerOne.chosenGesture == playerTwo.chosenGesture)
            {
                Console.WriteLine();
                Console.WriteLine("This Round Was a tie");
                Console.WriteLine();
            }
            else if (playerOne.chosenGesture == "rock" && playerTwo.chosenGesture == "paper")
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
            else if (playerOne.chosenGesture == "rock" && playerTwo.chosenGesture == "lizard")
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
            else if (playerOne.chosenGesture == "paper" && playerTwo.chosenGesture == "Spock")
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
            


        }
    }
}







        

