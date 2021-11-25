using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Final_hw; // чтобы каждый раз не писать Namespace

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Service_staff service_man = new Service_staff("Kakabaevich Luka Alexeevich", "Washer", new DateTime(1995, 12, 1), new DateTime(2017, 12, 1, 12, 1, 5), 20, 45, true, 5);
            service_man.Work_Experience();
            service_man.Salary();
            service_man.Age();
            service_man.Vacation();
            service_man.Bonus();
            service_man.Print();
            // добавь справку и хватит
        }
    }
}

