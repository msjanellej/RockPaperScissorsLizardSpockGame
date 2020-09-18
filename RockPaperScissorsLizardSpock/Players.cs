using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    class Players
    {
        //member variables
        // name
        // 

        //constructor
        public Players()
        {

        }

        // member methods
        // use inheritance and develop Human Class & AI class from here.
        // Choose Number of Players  .. 
        public void ChoosePlayers()
        {
            Console.WriteLine("Please Choose The Number of Players");
            Console.WriteLine("Choose 1 for One Player. Choose 2 for Two Players");
            string numberOfPlayers = Console.ReadLine();
            switch (numberOfPlayers)
            {
                case "1":
                    Console.WriteLine("You have chosen one player. You will play against the computer.");
                    break;
                case "2":
                    Console.WriteLine("You have chosen two players. You will battle each other. ");
                    break;
                
            //}
            //if (int.Parse(numberOfPlayers) == 1)
            //{
            //    //run one player option possibly return 1?
            //}
            //if (int.Parse(numberOfPlayers) == 2)
            //{
            //    // run two player option possibly return 2?
            }

        }
    }
}
