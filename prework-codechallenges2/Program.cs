using System;

namespace prework_codechallenges2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter 5 numbers between 1-10");
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
                    Console.WriteLine(userChoice * score);
                }
            }
            Console.ReadLine();
        }
    }
}
