using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLader
{
    
    internal class SnakeAndLader
    {
        const int NO_PLAY= 0, LADDER = 1, SNAKE = 2 , WINNING_POSITION = 100,STARTING_POSITION=0;

        int position = 0,count=0;
        Random random = new Random();   
        public int DieRoll()
        {
            int diePosition = random.Next(1,7);
            Console.WriteLine( "Die Position is"+diePosition);
            count++;
            return diePosition;
        }
        public void Game()
        {
            int option = random.Next(0,3);
            while (this.position < WINNING_POSITION)
            {
                switch (option)
                {
                    case NO_PLAY:
                        break;
                    case LADDER:
                        int dice = DieRoll();
                        if (this.position+dice<100)
                            this.position += dice;
                        break;
                    case SNAKE:
                        dice = DieRoll();
                        if (this.position<STARTING_POSITION )
                            this.position = 0;
                        else
                            this.position -= dice;
                        break;
                }
            }
            Console.WriteLine("the total number of dice rolled "+count);
        } 

    }
}
