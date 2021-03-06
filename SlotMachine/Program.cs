﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlotMachine
{
    class Program
    {
        /*
         * Welcome message
         * Directions
         * Choose a machine
         * Place a bet
         * Pull lever
         * Randomly rolls around and gives you 
         * Machine tells you if you won or not
         */
        static void Main(string[] args)
        {
            SlotMachine myMachine = new SlotMachine(); // 3 slots, 5 icons per slot

            Console.WriteLine("Welcome to slots!");

            Console.WriteLine("Directions");

            while (myMachine.GetPayout() == 0)
            {
                // place a bet
                do
                {
                    Console.WriteLine("Type in how many dollars to bet");
                    

                    // You could get this using:
                    // int userBet = Convert.ToInt32(Console.ReadLine());
                    // myMachine.CurrentBet = userBet;
                    myMachine.CurrentBet = Convert.ToInt32(Console.ReadLine());
                    if (!(myMachine.CurrentBet > 0 && myMachine.CurrentBet < 21))
                    {
                        Console.WriteLine("Please enter a number between 1 and 20");
                    }
                }
                while (!(myMachine.CurrentBet > 0 && myMachine.CurrentBet < 21));

                // pull the lever
                Console.WriteLine("Press enter to pull the lever");
                Console.ReadKey(); // TODO Later: make this actually look for ENTER
                myMachine.PullLever();

                // display the results
                int[] tempResults = myMachine.GetResults();
                for (int i = 0; i < tempResults.Length; i++)
                {
                    Console.Write(tempResults[i] + " ");
                }

                // payout
                
                Console.WriteLine("You won {0} pennies!", myMachine.GetPayout());
            }
            Console.ReadKey();

        }
    }
}
