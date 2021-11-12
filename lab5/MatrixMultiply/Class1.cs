using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixMultiply
{
    class DataHandling
    {  
        public static int[] Enter()
        {
            List<int> nums = new List<int>();   // динамический массив
            string answer = "Start";
            while (answer != "Stop")
            {
                Console.WriteLine("Write down the desired number.");
                int input = int.Parse(Console.ReadLine());
                nums.Add(input);
                Console.WriteLine("Would you like to continue entering some numbers? (Yes). If you get tired, just write \"Stop\".");
                answer = Console.ReadLine();
            }
            int[] new_array = nums.ToArray(); // convert from list to array
            return new_array;
        }
        public static int Summa(int[] new_array)
        {
            int summa = 0;
            foreach (int element in new_array)
            {
                summa += element;
            }
            Console.WriteLine("Your summa is equal {0}.", summa);
            return summa;
        }
        public static void Average(int[] new_array, int summa)
        {
            float average = 0;
            average = summa / new_array.Length;
            Console.WriteLine("The average value is {0}.", average);
        }
        public static void side_summa_difference(int[] new_array)
        {
            int sum = 0;
            Console.WriteLine("If you want to sum all positive numbers, write \"Plus\". Otherwise, \"Min\".");
            if (Console.ReadLine() == "Plus")
            {
                foreach (int element in new_array)
                {
                    if (element > 0)
                    {
                        sum += element;
                    }
                }
                Console.WriteLine("Sum of positive numbers is {0}.", sum);
            }
            else
            {
                foreach (int element in new_array)
                {
                    if (element < 0)
                    {
                        sum += element;
                    }
                }
                Console.WriteLine("Sum of negative numbers is {0}., sum");
            }
        }
        public static void OddEven(int[] new_array)
        {
            int summa = 0;
            Console.WriteLine("Do you want to find a sum with odd numbers or even? Write \"Even\" or \"Odd\".");
            if (Console.ReadLine() == "Even")
            {
                foreach (int number in new_array)
                {
                    if (number % 2 == 0)
                    {
                        summa += number;
                    }
                }
                Console.WriteLine("The sum of even numbers is {0}.", summa);
            }
            else
            {
                foreach (int number in new_array)
                {
                    if (number % 2 != 0)
                    {
                        summa += number;
                    }
                }
                Console.WriteLine("The sum of odd numbers is {0}.", summa);
            }
        }
        // Доп.задание
        public static void MaxMin(int[] new_array, ref int min_index, ref int max_index)
        {
            string choice = "Nothing";
            Console.WriteLine("Would you like to find a minimum or maximum number? Type \"Max\" or \"Min\".");
            int max = new_array.Max();
            int min = new_array.Min();
            max_index = Array.IndexOf(new_array, max); // Нашли первое совпадение
            min_index = Array.IndexOf(new_array, min);
            if (Console.ReadLine() == "Max")
            {
                choice = "Max";
                Console.WriteLine("{0} of our array is {1}. Index = {2}.", choice, max, max_index);
            }
            else
            {
                choice = "Min";
                Console.WriteLine("{0} of our array is {1}. Index = {2}.", choice, min, min_index);
            }
        }
        public static void Multipulti(int[] new_array, int max_index, int min_index)
        {
            int mult = 1; // так как произведение
            for (int num = min_index; num <= max_index; num++)
            {
                mult *= new_array[num];
            }
            Console.WriteLine("Multiplication between {0} and {1} is {2}.", min_index, max_index, mult);
        }
    }
}
