using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_hw
{
    public class Administator: Person, IEmployee
    {
        public string Surname { get; set; }
        public string Laboratory { get; set; }
        public DateTime Date_Of_Birthday { get; set; }
        public double Hours { get; set; }

        public double Pre_Experience { get; set; }
        public double Basic_Salary = 2000;
        public double total_salary_without_extra = 0;
        public double total_salary_with_extra;
        public bool vigovor = false;
        public DateTime Med_Straxovka { get; set; }
        public string vacation;

        public double Feedback { get; set; }
        public double during;
        public DateTime Approved { get; set; }
        public string expiration_of_med;
        public DateTime until;
        public double Amount { get; set; }
        double fine;

        public Administator(string surname, DateTime date_of_birthday, DateTime approved, double pre_experience, double hours, DateTime med_straxovka, double feedback, string laboratory)
        {
            this.Surname = surname;
            this.Date_Of_Birthday = date_of_birthday;
            this.Pre_Experience = pre_experience;
            this.Med_Straxovka = med_straxovka;
            this.Feedback = feedback;
            this.Hours = hours;
            this.Approved = approved;
            this.Laboratory = laboratory;
        }
        public Administator()
        {
        }
        public void Fine(string events) // из интерфейса
        {
            switch(events)
            {
                case "Smoking": fine += 100; break;
                case "Absenteeism": fine += 200; break;
                case "Sleep in the workplace": fine += 250; break;
                default: fine += 0; break;
            }
            Console.WriteLine("Actual fine is {0}$", fine);
        }
        public override void Move()
        {
            Console.WriteLine("\n \nNow we are looking at some information about Administrator");
        }

        public void Salary() // Сдельная оплата
        {
            total_salary_without_extra = Basic_Salary + (Approved.Month * 15);
        }
        public override void Age()
        {
            difference = DateTime.Now.Year - Date_Of_Birthday.Year;
        }
        public void Vigovor_plus()
        {
            vigovor = true;
        }
        public void Vigovor_minus()
        {
            vigovor = false;
        }
        public void Work_Experience()
        {
            during = ((DateTime.Now.Year - Approved.Year) * 12) + Math.Abs(DateTime.Now.Month - Approved.Month);
        }

        public void Extension()
        {
            if (((DateTime.Now.Year - Med_Straxovka.Year) * 12 + Math.Abs(DateTime.Now.Month - Med_Straxovka.Month)) >= 12)
            {
                expiration_of_med = "This person should have expirated med straxovka!";
            }
            else
            {
                expiration_of_med = "Med straxovka is still working.";
            }
            until = Med_Straxovka.AddYears(1);
        }
        public void Vacation()
        {
            if (vigovor == false)
            {
                vacation = "The third order line.";
                if (during > 24 && Hours >= 30 && Feedback >= 4)
                {
                    vacation = "The second order line";
                }
                else
                {
                    vacation = "The fourth order line";
                }
            }
            else
            {
                vacation = "The second order line.";
                if (during >= 24 && Hours >= 70 && Feedback == 5)
                {
                    vacation = "The first order line";
                }
                else
                {
                    vacation = "The second order line";
                }
            }
        }
        public void Bonus()
        {
            if (vigovor == false)
            {
                total_salary_with_extra = total_salary_without_extra * 1.05f;
                if (during > 36 && Hours >= 60)
                {
                    total_salary_with_extra *= 1.05f;
                }
            }
            else
            {
                if (during >= 24 && Hours >= 35)
                {
                    total_salary_with_extra = total_salary_without_extra * 1.15f;
                }
                else
                {
                    total_salary_with_extra = total_salary_without_extra * 1.1f;
                }
            }
            total_salary_with_extra = (total_salary_with_extra * ((Feedback * 0.01f + 1) + Pre_Experience * 0.003));
            total_salary_with_extra = Math.Round(total_salary_with_extra, 2);

        }

        public override string ToString()
        {
            string bs = String.Format("\nСотрудник: {0} \n   Администратор {1} \n   Дата Рождения: {2} \n   Прошлый опыт (в месяцах) : {3}\n   " +
                "Мед.страховка от {4}. Время окончания действия страховки: {5} - {6} \n   Принят на работу: {7} \n   Количество выработанных часов за неделю: {8}\n   Наличие выговоров: {9}\n   Очередь в отпуск: {10}\n   Итоговая зарплата" +
                ": {11}$\n   Возраст: {12}.", Surname, Laboratory, Date_Of_Birthday, Pre_Experience, Med_Straxovka, until, expiration_of_med, Approved, Hours, vigovor, vacation, total_salary_with_extra, difference);
            return bs;
        }
        public override void Print()
        {
            Console.WriteLine(this);
        }
    }
}
