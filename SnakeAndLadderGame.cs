using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    //UC1
    public static class SnakeAndLadderGame
    {
        const int position = 0;
        public static void CheckDieRoll()
        {
            Console.WriteLine("The starting position is -> "+position);
            Random random = new Random();
            int DiePosition = random.Next(1, 7);
            Console.WriteLine("Die Number is -> : " + DiePosition);
        }
    }
}
