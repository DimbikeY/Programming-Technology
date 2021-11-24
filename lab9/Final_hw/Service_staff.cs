using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_hw
{
    public class Service_staff
    {
        public string Surname { get; set; }
        public float Hours { get; set; }
        public string Kind_of_Work { get; set; }
        public DateTime Date_of_Birthday { get; set; }
        public float Experience { get; set; }
        public static float Basic_Salary = 1500;
        public float total_salary;
        public string age;
        public bool vigovor = false;
        public bool Med_Straxovka { get; set; }
        public string vacation;
        public int difference;
        public float Feedback { get; set; }


        public Service_staff(string surname, string kind_of_work, DateTime date_of_birthday, float experience, float hours, bool med_straxovka, float feedback)
        {
            this.Surname = surname;
            this.Kind_of_Work = kind_of_work;
            this.Date_of_Birthday = date_of_birthday;
            this.Experience = experience;
            this.Med_Straxovka = med_straxovka;
            this.Feedback = feedback;
            this.Hours = hours;
        }

        public void Salary() // Сдельная оплата
        {
            total_salary = Basic_Salary + (Experience * 15);
        }
        public void Age()
        {
           difference = DateTime.Now.Year - Date_of_Birthday.Year;
            Console.WriteLine("How");
        }
        public void Vigovor_plus() 
        {
            vigovor = true;
        }
        public void Vigovor_minus()
        {
            vigovor = false;
        }

        public void Extension()
        {
            Med_Straxovka = true;
        }
        public void Vacation()
        {
            if (vigovor == false)
            {
                vacation = "The third order line.";
                if (Experience > 24 && Hours >= 30 && Feedback >= 4)
                {
                    vacation = "The second order line.";
                }
                else
                {
                    vacation = "The fourth order line.";
                }
            }
            else
            {
                vacation = "The second order line.";
                if (Experience >= 24 && Hours >= 70 && Feedback == 5)
                {
                    vacation = "The first order line.";
                }
                else
                {
                    vacation = "The second order line.";
                }
            }
        }
        public void Bonus()
        {
            if (vigovor == false)
            {
                total_salary *= 1.05f;
                if (Experience > 36 && Hours >= 60)
                {
                    total_salary *= 1.05f;
                }
            }
            else
            {
                if (Experience >= 24 && Hours >= 35)
                {
                    total_salary *= 1.15f;
                }
                else
                {
                    total_salary *= 1.1f;
                }
            }
            total_salary *= (1 + Feedback) * 0.01f;
        }

        public override string ToString()
        {
            string answer = String.Format("\n Сотрудник: {0}\n Вид деятельности обслуживающ" +
                "его персонала: {1}\n Возраст: {2}\n Стаж работы (в месяцах): {3}\n Количество отработанных часов за месяц: {4} \n" +
                "Заработная плата: {5}\n Количество выговоров: {6}\n Приоритетность выдачи отпускных: {7}\n Мед.страховка: {8}" +
                "\n Общая оценка эффективности: {9}.", Surname, Kind_of_Work, difference, Experience, Hours, total_salary, vigovor, vacation, Med_Straxovka, Feedback);
            return answer;
        }
        public void Print()
        {
            Console.WriteLine(this);
        }
    }
}
