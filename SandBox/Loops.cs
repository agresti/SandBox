﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SandBox
{
    class Loops
    {
        static void Main(string[] args)
        {
            /*
            1 - Write a program to count how many numbers between 1 and 100 are divisible
            by 3 with no remainder.Display the count on the console.
            */
            
            var count = 0;
            for (var i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                    count++;
            }
            Console.WriteLine("There are {0} numbers divisible by 3", count);

            /*
            2- Write a program and continuously ask the user to enter a number or "ok" to exit. 
            Calculate the sum of all the previously entered numbers and display it on the console.
            */ 

            var sum = 0;
            while (true)
            {
                Console.WriteLine("Enter the Number or OK to exit");
                var input = Console.ReadLine();

                if (input.ToLower() == "ok")
                    break;

                sum += Convert.ToInt32(input);
            }
            Console.WriteLine("Sum of all: " + sum);

            /*
            3- Write a program and ask the user to enter a number. Compute the factorial of 
            the number and print it on the console. For example, if the user enters 5, 
            the program should calculate 5 x 4 x 3 x 2 x 1 and display it as 5! = 120.
            */

            Console.WriteLine("Enter the Number");
            var numberF = Convert.ToInt32(Console.ReadLine());

            var factorial = 1;
            for (var i = 1; i <= numberF; i++)
            {
                factorial *= i;
                Console.WriteLine("{0}! = {1}", numberF, factorial);
            }

            /*
            4- Write a program that picks a random number between 1 and 10. Give the 
            user 4 chances to guess the number.If the user guesses the number, display 
            “You won"; otherwise, display “You lost". (To make sure the program is behaving
            correctly, you can display the secret number on the console first.)
            */
            
            int numberR = new Random().Next(10);
            Console.WriteLine("Secret is " + numberR);
            for (var i = 0; i <= 4; i++)
            {
                Console.WriteLine("Guess the number ");
                var guess = Convert.ToInt32(Console.ReadLine());
                if (numberR == guess)
                {
                    Console.WriteLine("You won");
                }
                else
                {
                    Console.WriteLine("You lost");
                }
            }

            /*
            5- Write a program and ask the user to enter a series of numbers separated by comma. 
            Find the maximum of the numbers and display it on the console. For example,
            if the user enters “5, 3, 8, 1, 4", the program should display 8.
            */

            Console.Write("Enter comma separated numbers");
            var inputM = (Console.ReadLine());
            var numbers = inputM.Split(',');
            // Assume the first number is the max
            var max = Convert.ToInt32(numbers[0]);

            foreach (var str in numbers)
            {
                var number = Convert.ToInt32(str);
                if (number > max)
                    max = number;
            }
            Console.Write("Max: " + max);
        }
    }
}
