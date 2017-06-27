using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEC_Final_Project_NRB
{
    class Menu
    {
        
        TicTacToe T = new TicTacToe();
        RockPaperScissor R = new RockPaperScissor();

        string input1;
        public void PrintMenu()
        {

            while (true)
            {
                Console.Clear();
                Console.WriteLine("____________________________");
                Console.WriteLine("Welcome to the game room \n");
                Console.WriteLine("Choose your game: \n");
                Console.WriteLine("1. Tic Tac Toe \n");
                Console.WriteLine("2. Rock Paper Scissor \n");
                Console.WriteLine("3. exit");
           
                input1 = Console.ReadLine();
                MenuChoose(input1);
            }     
           
        }
        public void MenuChoose(string input)
        {
            int choice;
            if (Int32.TryParse(input, out choice))
            {


                switch (choice)
                {
                    case 1:
                        T.TicTacToeGame();
                        break;
                    case 2:
                        R.RockPaperScissorGame();
                        break;
                    case 3:
                        System.Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Choose a value of 1 2 or 3");
                        Console.ReadKey();
                        break;

                }

            } else
            {
                Console.WriteLine("Invalid input");
                Console.ReadKey();
            }
        }

    }
}
