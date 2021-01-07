using System;

namespace prework_codechallenges2
{
    class Program
    {
        static void Main(string[] args)
        {
            //numberArrayGame();
            leapYearCalculator();
        }
        static void numberArrayGame()
        {
            Console.WriteLine("enter 5 numbers between 1-10, seperated by spaces");
            string userInput = Console.ReadLine();
            string[] userNums = userInput.Split(' ');
            int[] realUserNums = new int[5];

            for (var i = 0; i < 5; i++)
            {
                realUserNums[i] = int.Parse(userNums[i]);
                Console.WriteLine(realUserNums[i].ToString());
            }
            Console.WriteLine("choose a number from these numbers");
            int userChoice = int.Parse(Console.ReadLine());

            int score = 0;
            foreach (int num in realUserNums)
            {
                if (userChoice == num)
                {
                    score++;
                }
            }
            Console.WriteLine("That number scored: {0}", userChoice * score);
            Console.ReadLine();
        }
        static void leapYearCalculator()
        {
            Console.WriteLine("Please enter a year...");
            int userYear = int.Parse(Console.ReadLine());
            if (userYear % 4 == 0 && (userYear % 100 != 0 || userYear % 400 == 0))
                {
                    Console.WriteLine("That is a Leap Year!")
                }
            else
            {
                Console.WriteLine("Not a Leap Year!");
            }
        }
    }
}
