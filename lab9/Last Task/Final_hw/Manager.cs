using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_hw
{ 
    public class Manager: Person, IEmployee  // добавили case в количестве кадров
    {
        public string Surname { get; set; }
        public string Department { get; set; }
        public string Profession { get; set; }
        public string Kind_of_Work { get; set; }
        public DateTime Date_of_Birthday { get; set; }
        public double Hours { get; set; }
        public double coefficient;

        public double Pre_Experience { get; set; }
        public double Basic_Salary = 1700;
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
        public double fine;

        public Manager(string surname, string kind_of_work, DateTime date_of_birthday, DateTime approved, double pre_experience, double hours, DateTime med_straxovka, double feedback, string department, double amount_of_people)
        {
            this.Surname = surname;
            this.Kind_of_Work = kind_of_work;
            this.Date_of_Birthday = date_of_birthday;
            this.Pre_Experience = pre_experience;
            this.Med_Straxovka = med_straxovka;
            this.Feedback = feedback;
            this.Hours = hours;
            this.Approved = approved;
            this.Department = department;
            this.Amount = amount_of_people;
        }
        public Manager()
        {
            
        }
        public override void Move()
        {
            Console.WriteLine("\n \nNow we are looking at some information about Manager");
        }
        public void Amount_of_people()
        {
          if (Amount >= 5 && Amount <= 10)
            {
                total_salary_without_extra *= 1.1; 
            }
          else if  (Amount <= 20)
            {
                total_salary_without_extra *= 1.15;
            } 
          else
            {
                total_salary_without_extra *= 1.2;
            } 
            
        }
        public void Fine(string events) // из интерфейса
        {
            switch (events)
            {
                case "Smoking": fine += 200; break;
                case "Absenteeism": fine += 100; break;
                case "Sleep in the workplace": fine += 150; break;
                default: fine += 0; break;
            }
            Console.WriteLine("Actual fine is {0}$", fine);
        }
        public void Work_Experience()
        {
            during = ((DateTime.Now.Year - Approved.Year) * 12) + Math.Abs(DateTime.Now.Month - Approved.Month);
        }
        public void Salary() // Сдельная оплата
        {
            total_salary_without_extra = Basic_Salary + (Approved.Month * 15);
        }
        public override void Age()
        {
            difference = DateTime.Now.Year - Date_of_Birthday.Year;
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
            if (((DateTime.Now.Year - Med_Straxovka.Year) * 12 + Math.Abs(DateTime.Now.Month - Med_Straxovka.Month)) >= 12)
            {
                expiration_of_med = "This person should have expirated med straxovka!";
            }
            else
            {
                expiration_of_med = "Med straxovka is still  working.";
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
            string bs = String.Format("\nСотрудник: {0} \n   Принят на работу: {1}  \n   Вид деятельности лектора:" +
                " {2} Департамента {14} \n   Возраст: {3} \n   Стаж работы на данном месте (в месяцах): {4} \n   Стаж работы до этой работы на данной специальности (в месяцах): {5} \n   Количество средних отработанных часов за неделю в течение месяца: {6} \n  " +
                 " Заработная плата: {7}$ \n   Наличие выговоров: {8} \n   Приоритетность выдачи отпускных: {9} \n   Мед.страховка от: {10}" +
                 " \n   Время окончания действия страховки: {11} - {12} \n   Общая оценка эффективности: {13} \n   Количество подчиненного состава: {15}.", Surname, Approved, Kind_of_Work, difference, during, Pre_Experience, Hours, total_salary_with_extra, vigovor, vacation, Med_Straxovka, until, expiration_of_med, Feedback, Department, Amount);
            return bs;
        }
        public override void Print()
        {
            Console.WriteLine(this);
        }

    }
}
