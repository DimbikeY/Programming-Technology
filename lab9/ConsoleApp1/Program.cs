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
            Service_staff service_man = new Service_staff("Kakabaevich Luka Alexeevich", "Washer", new DateTime(1995, 12, 1), new DateTime(2017, 12, 1, 12, 1, 5), 20, 55, new DateTime(2021, 5, 1), 5);
            service_man.Work_Experience();
            service_man.Salary();
            service_man.Age();
            service_man.Vacation();
            service_man.Bonus();
            service_man.Extension();
            service_man.Print();



            Lecturer lecturer = new Lecturer("Dobriborch Dmitrii Anatolievich", "Teacher of Maths", new DateTime(1983, 12, 5), new DateTime(2004, 5, 4), 40, 65, new DateTime(2021, 5, 5, 11, 5, 3), 5, "ФСУиР", "PhD");
            lecturer.Work_Experience();
            lecturer.Coefficient_detector();
            lecturer.Salary();
            lecturer.Age();
            lecturer.Vacation();
            lecturer.Bonus();
            lecturer.Extension();
            lecturer.Print();

        }
    }
}

