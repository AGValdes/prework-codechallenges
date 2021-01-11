using System;

namespace prework_codechallenges2
{
    class Program
    {
        static void Main(string[] args)
        { 
            int[] someArray = new int[] { 1,2,3 };
            numberArrayGame();
            leapYearCalculator();
            perfectSequence(someArray);
            sumOfRows(); 
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

                Console.WriteLine("That is a Leap Year!");
            }
            else
            {
                Console.WriteLine("Not a Leap Year!");
            }
        }
            static void perfectSequence(int[] someArray)
            {
                int sum = 0, prod = 1;
              
                foreach (int value in someArray)
                {
                    sum += value;
                    prod *= value;
                }

                if(sum == prod)
                {
                    Console.WriteLine("Yes");
                }
                else
                {
                    Console.WriteLine("No");
                }
            
        }
        static int[] sumOfRows()
        {

            //couldn't quite figure out how to do it with user input :(
            /*int m = 0;
             int n = 0;
             Console.WriteLine("Please Enter Any Number of Arrays of Integers of Any Length, Seperating each number with a space and each group by a comma with no fololowing space");
             string rawUserInput = Console.ReadLine();
             string[] outterArray = rawUserInput.Split(',');


             for (int i = 0; i < outterArray.Length; i++)
             {
                 string[] innerArray = outterArray[i].Split(' ');
                 Console.WriteLine(innerArray[i]);*/
            

            int[,] multiArray = new int[3, 5] { { 1, 2, 3, 4, 5 }, { 6, 7, 8, 9, 10 }, { 11, 12, 13, 14, 15 } };
            int[] singleArray = new int[multiArray.GetLength(0)];
            for (int i = 0; i < multiArray.GetLength(0); i++)
            {
                for (int j = 0; j < multiArray.GetLength(1); j++)
                {
                    singleArray[i] += multiArray[i, j];
                }
            }
            Console.WriteLine($"[{string.Join(", ", singleArray)}]");
            return singleArray;

            }
        }
    }

