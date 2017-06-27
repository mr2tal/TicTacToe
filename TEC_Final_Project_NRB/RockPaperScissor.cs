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
            string[] arr = {"", "rock", "paper", "scissor" };
            string input;
            int win = 0;
            Random rnd = new Random();
            while (win == 0)
            {
                Console.Clear();
                Console.WriteLine("Welcome to Rock Paper Scissor");
                Console.WriteLine("Choose 1. rock  2. paper or 3. scissor");

                input = Console.ReadLine();

                int choice;
                if (Int32.TryParse(input, out choice) == false)
                {
                    Console.WriteLine("Invalid input");
                    Console.ReadKey();
                    RockPaperScissorGame();
                }
                  else if (choice > 0 && choice < 4)
                    {
                        Console.WriteLine("Player choose {0}. {1}", input, arr[choice]);
                    }
                    else
                    {
                        Console.WriteLine("invalid input, input should be from 1 to 3");
                    }
                
                
                int cominput = rnd.Next(1, 4);

                Console.WriteLine("Computer choose {0}", arr[cominput]);

                //choice 1 = rock, 2 = paper , 3 = scissor
                //win 1 = draw, 2 = player , 3 = computer

                if (choice == 1 && cominput == 1)
                {
                    win = 1;
                }
                else if (choice == 2 && cominput == 2)
                {
                    win = 1;
                }
                else if (choice == 3 && cominput == 3)
                {
                    win = 1;
                }
                else if (choice == 1 && cominput == 2)
                {
                    win = 3;
                }
                else if (choice == 1 && cominput == 3)
                {
                    win = 2;
                }
                else if (choice == 2 && cominput == 1)
                {
                    win = 2;
                }
                else if (choice == 2 && cominput == 3)
                {
                    win = 3;
                }
                else if (choice == 3 && cominput == 1)
                {
                    win = 3;
                }
                else if (choice == 3 && cominput == 2)
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
