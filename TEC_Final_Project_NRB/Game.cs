﻿using System;
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
            bool win = false;

            while (win == false)
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
                if (arr[0] == arr[1] && arr[1] == arr[2])
                {
                    win = true;
                }
                else if (arr[3] == arr[4] && arr[4] == arr[5])
                {
                    win = true;
                }
                else if (arr[6] == arr[7] && arr[7] == arr[8])
                {
                    win = true;
                }
                else if (arr[0] == arr[3] && arr[3] == arr[6])
                {
                    win = true;
                }
                else if (arr[1] == arr[4] && arr[4] == arr[7])
                {
                    win = true;
                }
                else if (arr[2] == arr[5] && arr[5] == arr[8])
                {
                    win = true;
                }
                else if (arr[0] == arr[4] && arr[4] == arr[8])
                {
                    win = true;
                }
                else if (arr[2] == arr[4] && arr[4] == arr[6])
                {
                    win = true;
                }
            


            }
            Console.WriteLine("you win");



        }


        public void FourOnARow()
        {

        }
    }
}