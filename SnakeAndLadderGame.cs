﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    
    public class SnakeAndLadderGame
    {
        const int NO_PLAY = 0, SNAKE = 1, LADDER = 2;
        int position = 0;
        public int CheckDieRoll()
        {
            Console.WriteLine("The starting position is -> "+position);
    
            Random random = new Random();
            int DiePosition = random.Next(1, 7);
            Console.WriteLine("Die Number is -> : " + DiePosition);
            return DiePosition;
        }
        public void Game()
        {
            while (this.position < 100)
            {
                Random random = new Random();
                int option = random.Next(0, 3);
                switch (option)
                {
                    case NO_PLAY:
                        this.position += 0;
                        break;
                    case SNAKE:
                        this.position -= this.CheckDieRoll();
                        break;
                    case LADDER:
                        this.position += this.CheckDieRoll();
                        break;
                    default:
                        Console.WriteLine("Wrong Choice");
                        break;
                }
            }
        }
    }
}
