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
            Random die = new Random();
            int enemy = 3;
            int attackNow = 0;

            int dieNumber = die.Next(1, 5);
            int attack = dieNumber;
            attackNow += attack;
            dieNumber = die.Next(1, 5);
            while (dieNumber > attack)
            {
                attackNow += attack;
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
