using System;

namespace Task
{
    class Program
    {
        public struct Distance // Структура, содержащая следующие  поля.
        {
            public decimal height_m;
            public decimal height_s;
            public string answer;
        }
            
        public static void Main(string[] args)
        {
            try
            {
                Distance sample; // Переменная типа Distance.
                Console.WriteLine("Write the whole part of your height in meters");
                sample.height_m = decimal.Parse(Console.ReadLine());
                Console.WriteLine("Write your height in centimeters, reduced by 100 ");
                sample.height_s = decimal.Parse(Console.ReadLine());
                if (sample.height_m < 0 || sample.height_s < 0)
                {
                    Console.WriteLine("Are you crazy? How is it possible?");
                }
                else
                {
                    decimal summa_both = (sample.height_m * 100) + sample.height_s;
                    decimal length = summa_both / 2.54m; // Дюймы
                    int foot = Decimal.ToInt32(length / 12);
                    int inch = Decimal.ToInt32(length % 12);
                    sample.answer = foot + " '- " + inch +'\u0022' + '.';
                    Console.WriteLine(sample.answer) ; // Символ Юникода одинарных кавычек
                }
            }
            catch(FormatException)
            {
                Console.WriteLine("Use only positive numbers!");
            }



            









        }
    }
}
