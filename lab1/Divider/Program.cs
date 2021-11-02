using System;

namespace Divider
{
    class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please enter the first integer.");
                string temp = Console.ReadLine();
                int i = Int32.Parse(temp);
                Console.WriteLine("Please enter the second integer.");
                temp = Console.ReadLine();
                int j = Int32.Parse(temp);
                Console.WriteLine("We are checking the possibility to divide.");
                int k = i / j;
                Console.WriteLine("Well done! This is possible.");
                Console.WriteLine("The result of dividing {0} by {1} is {2}.", i, j, k);
            }
            catch (FormatException e)
            {
                Console.WriteLine("An format exception was thrown: {0}", e.Message);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("An DivideByZero exception was thrown: {0}", e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("An exception was thrown: {0}", e.Message);
            }
        }
    }
}

