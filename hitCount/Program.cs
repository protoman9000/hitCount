using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hitCount
{
    class Program
    {
        static void Main(string[] args)
        {
            Random die = new Random();   //new die
            int enemy = 3;               //enemy health
            int attackNow = 0;           //total attack points

            int dieNumber = die.Next(1, 5);
            int attack = dieNumber;
            attackNow += attack;
            dieNumber = die.Next(1, 5);
            
            while (dieNumber > attack)   //If the next roll is higher than last, adds to the total. 
            {
                attackNow += dieNumber;
                attack = dieNumber;
                dieNumber = die.Next(1, 5);
            }

            int result = enemy - attackNow;

            if (result <= 0)
                Console.WriteLine("The enemy is defeated");
            else
                Console.WriteLine("You lost, try again");
        }
    }
}
