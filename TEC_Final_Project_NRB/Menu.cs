using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEC_Final_Project_NRB
{
    class Menu
    {
        Game g = new Game();
        string input1;
        public void PrintMenu()
        {
            while (true)
            {
                Console.WriteLine("____________________________");
                Console.WriteLine("Welcome to the game room \n");
                Console.WriteLine("Choose your game: \n");
                Console.WriteLine("1. Tic Tac Toe \n");
                Console.WriteLine("2. 4 on a row \n");
                Console.WriteLine("3. exit");
           
                input1 = Console.ReadLine();
                MenuChoose(int.Parse(input1));
            }     
           
        }
        public void MenuChoose(int input)
        {
       
                switch (input)
                {
                    case 1:
                        g.TicTacToe();
                        break;
                    case 2:
                        g.FourOnARow();
                        break;
                    case 3:
                        System.Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Choose a value of 1 2 or 3");
                        break;

                }
        }

    }
}
