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
            Person common_abstract;
            Service_staff service_man = new Service_staff("Kakabaevich Luka Alexeevich", "Washer", new DateTime(1995, 12, 1), new DateTime(2017, 12, 1, 12, 1, 5), 20, 55, new DateTime(2021, 5, 1), 5);
            service_man.Work_Experience();
            service_man.Salary();
            service_man.Age();
            service_man.Vacation();
            service_man.Bonus();
            service_man.Extension();
            common_abstract = service_man;
            common_abstract.Move();
            service_man.Print();
            service_man.Fine("Smoking");



            Lecturer lecturer = new Lecturer("Dobriborch Dmitrii Anatolievich", "Teacher of Maths", new DateTime(1983, 12, 5), new DateTime(2004, 5, 4), 40, 65, new DateTime(2021, 5, 5, 11, 5, 3), 5, "ФСУиР", "PhD");
            lecturer.Work_Experience();
            lecturer.Coefficient_detector();
            lecturer.Salary();
            lecturer.Age();
            lecturer.Vacation();
            lecturer.Bonus();
            lecturer.Extension();
            common_abstract = lecturer;
            common_abstract.Move();
            lecturer.Print();
            lecturer.Fine("Smoking");


            Manager manager = new Manager("Salamatova Anaida Lukievna", "Manager", new DateTime(1984, 1, 15), new DateTime(2017, 7, 12), 30, 45, new DateTime(2021, 11, 20, 10, 3, 5), 5, "ИКТ", 23);
            manager.Work_Experience();
            manager.Salary();
            manager.Amount_of_people();
            manager.Age();
            manager.Vacation();
            manager.Bonus();
            manager.Extension();
            common_abstract = manager;
            common_abstract.Move();
            manager.Print();
            manager.Fine("Smoking");

            Student student = new Student("Kekelov Michel Andeerivh", "ФФиоИ", new DateTime(2002, 10, 12), "Дворник", "K3221", "Balchelor", new DateTime(2021, 5, 2, 13, 21, 15), 5, 0);
            student.Extension();
            student.Basic_Schoolarship();
            student.Upper_scolarship();
            common_abstract = student;
            common_abstract.Move();
            student.Print();

            Administator admin = new Administator("Akakiev Akakiy Akakievich", new DateTime(1917, 12, 1), new DateTime(2011, 12, 5), 500, 45, new DateTime(2020, 7, 12), 5, "лаборатории ноотропов");
            common_abstract = admin;
            common_abstract.Move();
            admin.Salary();
            admin.Work_Experience();
            admin.Age();
            admin.Extension();
            admin.Vacation();
            admin.Bonus();
            admin.Print();
            admin.Fine("Smoking");
        }
    }
}

