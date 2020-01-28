using System;

namespace GameDoanSo
{
    class Program
    {
        static void Game()
        {
            Random rd = new Random();
            int numberComputer = rd.Next(100);
            int numberByMe;
            int numberGuess = 0;
            Console.WriteLine("Computer Guessed, Please choose the my number");
            while (true)
            {
                
                numberByMe = int.Parse(Console.ReadLine());
                numberGuess++;
                Console.WriteLine("Guess number: {0}", numberGuess);
                if(numberByMe == numberComputer)
                {
                    Console.WriteLine("WIN!!!!!, Computer number is: {0}", numberComputer);
                    break;
                }
                if(numberByMe > numberComputer)
                {
                    Console.WriteLine("Your number > Computer number");
                }
                else
                {
                    Console.WriteLine("Your number < Computer number");
                }
                if(numberGuess == 7)
                {
                    Console.WriteLine("GAME OVER!!!!");
                    break;
                }
            }
        }
        static void Main(string[] args)
        {
            Game();
        }
    }
}
