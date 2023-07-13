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
        const int NO_PLAY= 0, LADDER = 1, SNAKE = 2 , WINNING_POSITION = 100 , STARTING_POSITION = 0;
        bool WON = false;
        public void SetPosition(int position)
        {
            this.position = position;
        }
        public int GetPosition()
        {
            return this.position;
        }
        public void SetCount(int count)
        {
            this.count = count;
        }
        public int GetCount()
        {
            return this.count;
        }
        public void SetWon(bool WON)
        {
            this.WON = WON;
        }
        public bool GetWon()
        {
            return this.WON;
        }


        int position = 0,count=0;
        Random random = new Random(); 
        
        public int DieRoll()
        {
            int diePosition = random.Next(1,7);
            //Console.WriteLine(this.position);
            this.count++;
            return diePosition;
        }
        public int PlayGame()
        {
            //while (this.position < WINNING_POSITION)
            //{
                int option = random.Next(0, 3);

                int dice = DieRoll();
                switch (option)
                {
                    case NO_PLAY:
                        break;
                    case LADDER:
                        
                        if (this.position+dice<=100)
                            this.position += dice;
                        break;
                    case SNAKE:
                        
                        if (this.position-dice<0 )
                            this.position = 0;
                        else
                            this.position -= dice;
                        break;
                    default:
                        break;
                }
                if (this.position==WINNING_POSITION)
                {
                    WON = true;
                }
            return this.position;
            //}
        } 

    }
}
