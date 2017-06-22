using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEC_Final_Project_NRB
{
    class RockPaperScissor
    {
        public void RockPaperScissorGame()
        {
            string[] arr = { "rock", "paper", "scissor" };
            int player = 0;
            string input;
            int win = 0;
            Random rnd = new Random();
            while (win == 0)
            {
                Console.Clear();
                Console.WriteLine("Welcome to Rock Paper Scissor");
                Console.WriteLine("Choose 1. rock  2. paper or 3. scissor");

                input = Console.ReadLine();

                int choice = int.Parse(input) - 1;
                if (choice >= 0 && choice < 3)
                {
                    Console.WriteLine("Player {0} choose {1}. {2}", player, input, arr[choice]);
                }
                else
                {
                    Console.WriteLine("invalid input, input should be from 1 to 3");
                }
                
                int cominput = rnd.Next(0, 3);

                Console.WriteLine("Computer choose {0}", arr[cominput]);
                // 1 = draw, 2 = player , 3 = computer
                // 0 = rock, 1 = paper , 2 = scissor
                if(choice == 0 && cominput == 0)
                {
                    win = 1;
                }
                else if (choice == 1 && cominput == 1)
                {
                    win = 1;
                }
                else if (choice == 2 && cominput == 2)
                {
                    win = 1;
                }
                else if (choice == 0 && cominput == 1)
                {
                    win = 3;
                }
                else if (choice == 0 && cominput == 2)
                {
                    win = 2;
                }
                else if (choice == 1 && cominput == 0)
                {
                    win = 2;
                }
                else if (choice == 1 && cominput == 2)
                {
                    win = 3;
                }
                else if (choice == 2 && cominput == 0)
                {
                    win = 3;
                }
                else if (choice == 2 && cominput == 1)
                {
                    win = 2;
                }
           
            }

            if(win == 1)
            {
                Console.WriteLine("Game is a draw");
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
            else if (win == 2)
            {
                Console.WriteLine("Player wins");
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
            else if (win == 3)
            {
                Console.WriteLine("Computer wins");
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
        }
    }
}
