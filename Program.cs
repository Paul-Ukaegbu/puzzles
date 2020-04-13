using System;
using System.Collections.Generic;

namespace puzzles
{
    public class Program{

        public static int TossCoin(){

            Random rand = new Random();
            return rand.Next(1, 100);
        }

        static void Main(string[] args){

            int coin = TossCoin();
            if (coin % 2 == 0){
                Console.WriteLine("Heads");
            }
            else{
                Console.WriteLine("Tails");
            }
        }


    }
}
