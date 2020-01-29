using System;
using System.Collections.Generic;
using System.Text;

namespace SandBox
{
    class ArraysLists
    {
        static void Main(string[] args)
        {
            ///1- When you post a message on Facebook, depending on the number of people who like your post, 
            ///Facebook displays different information.
            ///
            /// If no one likes your post, it doesn't display anything.
            /// If only one person likes your post, it displays: [Friend's Name] likes your post.
            /// If two people like your post, it displays: [Friend 1] and [Friend 2] like your post.
            /// If more than two people like your post, it displays: [Friend 1], [Friend 2] and [Number of Other
            /// People] others like your post.
            /// Write a program and continuously ask the user to enter different names, until the user presses Enter
            /// (without supplying a name). Depending on the number of names provided, display a message based on
            /// the above pattern.
            ///
            var names = new List<string>();

            while (true)
            {
                Console.WriteLine("Enter a name or hit ENTER to stop: ");

                var input = Console.ReadLine();
                if (String.IsNullOrEmpty(input))
                    break;
                names.Add(input);
            }

            if (names.Count > 2)
                Console.WriteLine("{0}, {1} and {2} others like your post", names[0], names[1], names.Count - 2);
            else if (names.Count == 2)
                Console.WriteLine("{0}, {1} like your post", names[0], names[1]);
            else if (names.Count == 1)
                Console.WriteLine("{0} likes your post", names[0]);
            else
                Console.WriteLine();





            /// 2- Write a program and ask the user to enter their name. Use an array to reverse the name a
            /// nd then store the result in a new string.Display the reversed name on the console.
            /// 
            Console.WriteLine("Add your name:");
            var yourName = Console.ReadLine();

            var array = new char[yourName.Length];
            for (var i = yourName.Length; i > 0; i--)
                array[yourName.Length - i] = yourName[i - 1];
            var reversed = new string(array);
            Console.WriteLine("reversed: " + reversed);





            ///3 - Write a program and ask the user to enter 5 numbers.If a number has been previously entered, 
            ///display an error message and ask the user to re-try. Once the user successfully enters 5 unique numbers,
            ///sort them and display the result on the console.
            ///
            var numbers1 = new List<int>();

            while (numbers1.Count < 5)
            {
                Console.Write("Enter a number: ");
                var number = Convert.ToInt32(Console.ReadLine());
                if (numbers1.Contains(number))
                {
                    Console.WriteLine("You've previously entered " + number);
                    continue;
                }

                numbers1.Add(number);
            }

            numbers1.Sort();

            foreach (var number in numbers1)
                Console.WriteLine(number);








            ///4- Write a program and ask the user to continuously enter a number or type "Quit" to exit. 
            ///The list of numbers may include duplicates.Display the unique numbers that the user has entered.
            ///

            var numbers = new List<int>();

            while (true)
            {
                Console.Write("Enter a number (or 'Quit' to exit): ");
                var input = Console.ReadLine();

                if (input.ToLower() == "quit")
                    break;

                numbers.Add(Convert.ToInt32(input));
            }

            var uniques = new List<int>();
            foreach (var number in numbers)
            {
                if (!uniques.Contains(number))
                    uniques.Add(number);
            }

            Console.WriteLine("Unique numbers:");
            foreach (var number in uniques)
                Console.WriteLine(number);









            /// 5- Write a program and ask the user to supply a list of comma separated numbers (e.g 5, 1, 9, 2, 10). 
            /// If the list is empty or includes less than 5 numbers, display "Invalid List" and ask the user to re-try;
            /// otherwise, display the 3 smallest numbers in the list.

            string[] elements;
            while (true)
            {
                Console.Write("Enter a list of comma-separated numbers: ");
                var input = Console.ReadLine();

                if (!String.IsNullOrWhiteSpace(input))
                {
                    elements = input.Split(',');
                    if (elements.Length >= 5)
                        break;
                }

                Console.WriteLine("Invalid List");
            }

            var numbers6 = new List<int>();
            foreach (var number in elements)
                numbers6.Add(Convert.ToInt32(number));

            var smallests = new List<int>();
            while (smallests.Count < 3)
            {
                // Assume the first number is the smallest
                var min = numbers6[0];
                foreach (var number in numbers6)
                {
                    if (number < min)
                        min = number;
                }
                smallests.Add(min);

                numbers6.Remove(min);
            }

            Console.WriteLine("The 3 smallest numbers are: ");
            foreach (var number in smallests)
                Console.WriteLine(number);


        }
    }
}

