/*
 * Author: Jessica C
 * Date: 1/30/2023
 * Description: C# Console Application for an iterative statement that collects numbers and displays a series.
 * */

using System;
namespace Deliverable3_IterativeStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = 0;
            string series = "";

            while (true)
            {
                Console.Write("Enter an integer between 1 and 100: ");
                input = int.Parse(Console.ReadLine());

                if (input >= 1 && input <= 100)
                {
                    break;
                }
            }

            while (true)
            {
                Console.Write("Specify the series type: Even or Odd: ");
                series = Console.ReadLine();

                if (series == "Even" || series == "Odd")
                {
                    break;
                }
            }


            if (series == "Odd")
            {
                Console.Write("You have selected " + series + " series. The numbers between 0 amd " + input + " are: ");
                for (int i = 1; i < input; i = i + 2)
                {
                    Console.WriteLine(i);
                }
            }

            if (series == "Even")
            {
                Console.Write("You have selected " + series + "series. The numbers between 0 amd " + input + " are: ");
                for (int i = 0; i < input; i = i + 2)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}