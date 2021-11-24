using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Final_hw; // чтобы каждый раз не писать Namespace

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Service_staff service_man = new Service_staff("Kakabaevich", "Washer", new DateTime(1994, 12, 1), 20, 45, true, 5);
            service_man.Salary();
            service_man.Age();
            service_man.Vacation();
            service_man.Bonus();
            service_man.Print();
            Console.WriteLine("Hi");
        }
    }
}

