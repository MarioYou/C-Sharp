using System;

namespace DiceGame
{
    class Program
    {
        static void Main(string[] args)
        {

            // initializing the integers 
            int PlayerRandNum;
            int PlayerPoints = 0;

            int OpponentRandNum;
            int OpponentPoints = 0;

            // creating a boolean to ask the players if they want to play again if its a tie. 
            Boolean Confirmed = true;

            // asking for player's names to use throughout the game. 
            Console.WriteLine("Please enter Player 1's name: ");
            String Player1 = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("Please enter Player 2's name: ");
            String Player2 = Console.ReadLine();

            Console.WriteLine();
            System.Threading.Thread.Sleep(1000); // Makes the game wait for 1000 ms

            // creating a random list
            Random Random = new Random();



            while (Confirmed == true) //  the while loop will continue as long as the user presses Y after a tie. 
            {
                // starting the for loop for the rounds 1 - 10 
                for (int i = 1; i <= 2; i++)
                {
                    Console.WriteLine("          Round " + i); // will display the rounds on top of each round
                    Console.WriteLine("Press any key to roll a dice.");
                    Console.WriteLine("-----------------------------");
                    Console.ReadKey();

                    PlayerRandNum = Random.Next(1, 7);

                    Console.WriteLine(Player1 + " rolled a " + PlayerRandNum);

                    Console.WriteLine("...");
                    System.Threading.Thread.Sleep(1000); // Makes the game wait for 1000 ms or 1 second.

                    OpponentRandNum = Random.Next(1, 7); // creates a random roll with 1 being the least and 7 being the highest 

                    Console.WriteLine(Player2 + " rolled a " + OpponentRandNum);
                    Console.WriteLine();


                    // counts the points to see who won the round. 
                    if (PlayerRandNum > OpponentRandNum)
                    {
                        PlayerPoints++;
                        Console.WriteLine("       " + Player1 + " won this round! Congratz!!");

                    }
                    else if (PlayerRandNum < OpponentRandNum)
                    {
                        OpponentPoints++;
                        Console.WriteLine("       " + Player2 + " won this round! Congratz!!");

                    }
                    else
                    {
                        Console.WriteLine("       Its a tie! Play again");
                    }
                    Console.WriteLine("       The score is now: " + Player1 + ": " + PlayerPoints + " | " + Player2 + ": " + OpponentPoints + ".");
                    Console.WriteLine();
                }


                // counts the points to see who won the game
                if (PlayerPoints > OpponentPoints)
                {
                    Console.WriteLine(Player1 + " won this game! Congratulations " + Player1);
                    Confirmed = false;

                }
                else if (PlayerPoints < OpponentPoints)
                {
                    Console.WriteLine(Player2 + " won this game! Congratulations " + Player2);
                    Confirmed = false; 
                }
                else
                {
                    Console.WriteLine("Its a tie! Play again? Y|N");
                    String Again = Console.ReadLine();
                    if (Again == "Y")
                    {
                        Confirmed = true;
                    }
                    else if (Again == "N")
                    {
                        Confirmed = false;
                    }
                }
            }

        }
    }
}