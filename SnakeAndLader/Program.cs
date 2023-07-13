using System;

namespace SnakeAndLader
{
    class Program
    {
        static void Main(string[] args)
        {
            SnakeAndLader player1 = new SnakeAndLader();
            SnakeAndLader player2 = new SnakeAndLader();

            string player1position = "";
            string player2position = "";
            
            while (!player1.GetWon() ||  !player2.GetWon())
            {
                
                player1position += player1.PlayGame() + " | ";
                player2position += player2.PlayGame()+" | ";

            }
            Console.WriteLine("position of player1 \n"+player1position);
            Console.WriteLine("position of player2 \n" + player2position);
            Console.WriteLine("the total number of dice rolled " + player1.GetCount());
            Console.WriteLine("the total number of dice rolled " + player2.GetCount());
            //Console.WriteLine( "last postion p1 "+player1.GetPosition());
            //Console.WriteLine( "last postion p2 "+player2.GetPosition());
            if (player1.GetWon()) Console.WriteLine("player 1 won");
            else if (player2.GetWon()) Console.WriteLine("player 2 won");


        }
    }
}
