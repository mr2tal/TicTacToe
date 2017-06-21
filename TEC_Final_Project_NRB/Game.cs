using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEC_Final_Project_NRB
{
    class Game
    {
        public void TicTacToe()
        {
            char[] arr = { '0', '1', '2', '3', '4', '5', '6', '7', '8' };
            int player = 0;
            string input;
            int win = 0;

            while (win == 0)
            {
                Console.WriteLine("Welcome to Tic tac toe \n");
                Console.WriteLine("{0} {1} {2}", arr[0], arr[1], arr[2]);
                Console.WriteLine("{0} {1} {2}", arr[3], arr[4], arr[5]);
                Console.WriteLine("{0} {1} {2}", arr[6], arr[7], arr[8]);
                if (player == 0)
                {
                    player = 1;
                }
                else if (player == 1)
                {
                    player = 2;
                }
                else if (player == 2)
                {
                    player = 1;
                }

                Console.WriteLine("Player {0} turn, input your choose between 0 and 8", player);
                input = Console.ReadLine();

                Console.WriteLine("player {0} choose {1}", player, input);

                int choice = int.Parse(input);
                if (arr[choice] != 'x' || arr[choice] != 'o')
                {
                    if (player == 1)
                    {
                        arr[choice] = 'x';
                    }
                    else if (player == 2)
                    {
                        arr[choice] = 'o';
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input, try again");
                }

                //win conditions
                if (arr[0] == arr[1] && arr[1] == arr[2])
                {
                    win = 1;
                }
                else if (arr[3] == arr[4] && arr[4] == arr[5])
                {
                    win = 1;
                }
                else if (arr[6] == arr[7] && arr[7] == arr[8])
                {
                    win = 1;
                }
                else if (arr[0] == arr[3] && arr[3] == arr[6])
                {
                    win = 1;
                }
                else if (arr[1] == arr[4] && arr[4] == arr[7])
                {
                    win = 1;
                }
                else if (arr[2] == arr[5] && arr[5] == arr[8])
                {
                    win = 1;
                }
                else if (arr[0] == arr[4] && arr[4] == arr[8])
                {
                    win = 1;
                }
                else if (arr[2] == arr[4] && arr[4] == arr[6])
                {
                    win = 1;
                }
                else if (arr[0] != '0' && arr[1] != '1' && arr[2] != '2' && arr[3] != '3' && arr[4] != '4' && arr[5] != '5' && arr[6] != '6' && arr[7] != '7' && arr[8] != '8')
                {
                    win = 2;
                }
            


            }
            if (win == 1)
            {
                if (player == 1)
                {
                    Console.WriteLine("{0} {1} {2}", arr[0], arr[1], arr[2]);
                    Console.WriteLine("{0} {1} {2}", arr[3], arr[4], arr[5]);
                    Console.WriteLine("{0} {1} {2}", arr[6], arr[7], arr[8]);
                    Console.WriteLine("player 1 wins \n");

                }
                else if (player == 2)
                {
                    Console.WriteLine("{0} {1} {2}", arr[0], arr[1], arr[2]);
                    Console.WriteLine("{0} {1} {2}", arr[3], arr[4], arr[5]);
                    Console.WriteLine("{0} {1} {2}", arr[6], arr[7], arr[8]);
                    Console.WriteLine("Player 2 wins \n");
                }
              
            }
            else if (win == 2)
            {
                Console.WriteLine("Draw");
            }
                
           



        }


        public void FourOnARow()
        {
            Console.WriteLine("Test");
        }
    }
}
