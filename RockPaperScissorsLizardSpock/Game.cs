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
        
        bool condition;
        public Comparative comparative;
        

        //constructor
        public Game()
        {
            playerOne = new Human();
            comparative = new Comparative();
            
            
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
        public void ChooseGameType() 
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
        public void DisplayWinner()
        {
            if (comparative.playerOneScore == 20)
            {
                Console.WriteLine();
                Console.WriteLine("Player One is victorious!!!");
            }
            if (comparative.playerTwoScore == 20)
            {
                Console.WriteLine();
                Console.WriteLine("Player Two is victorious!!!");
            }
        }
        public bool DoesGameContinue()
        {
            if (comparative.playerOneScore >= 20 || comparative.playerTwoScore >= 20)
            {
                return false;
            }
            else
            {
                return true;
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
                Console.WriteLine();
                playerTwo.ChooseGesture();           
                Console.WriteLine();
                comparative.CompareChoices(playerOne,playerTwo,comparative.playerOneScore, comparative.playerTwoScore);

            }
            DisplayWinner();

        }
    }
}
