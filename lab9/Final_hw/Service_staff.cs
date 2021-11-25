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
        public double Hours { get; set; }
        public string Kind_of_Work { get; set; }
        public DateTime Date_of_Birthday { get; set; }
        public double Pre_Experience { get; set; }
        public double Basic_Salary = 1500;
        public double total_salary_without_extra = 0;
        public double total_salary_with_extra;
        public bool vigovor = false;
        public bool Med_Straxovka { get; set; }
        public string vacation;
        public double difference;
        public double Feedback { get; set; }
        public double during;
        public DateTime Approved { get; set; }


        public Service_staff(string surname, string kind_of_work, DateTime date_of_birthday, DateTime approved, double pre_experience, double hours, bool med_straxovka, double feedback)
        {
            this.Surname = surname;
            this.Kind_of_Work = kind_of_work;
            this.Date_of_Birthday = date_of_birthday;
            this.Pre_Experience = pre_experience;
            this.Med_Straxovka = med_straxovka;
            this.Feedback = feedback;
            this.Hours = hours;
            this.Approved = approved;
        }
        public Service_staff()
        {
            
        }
        public void Work_Experience()
        {
            during = ((DateTime.Now.Year - Approved.Year) * 12) + Math.Abs(DateTime.Now.Month - Approved.Month);
        }
        public void Salary() // Сдельная оплата
        {
            total_salary_without_extra = Basic_Salary + (Approved.Month * 15);
        }
        public void Age()
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
            Med_Straxovka = true;
        }
        public void Vacation()
        {
            if (vigovor == false)
            {
                vacation = "The third order line.";
                if (Approved.Month > 24 && Hours >= 30 && Feedback >= 4)
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
                if (Approved.Month >= 24 && Hours >= 70 && Feedback == 5)
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
                if (Approved.Month > 36 && Hours >= 60)
                {
                    total_salary_with_extra *= 1.05f;
                }
            }
            else
            {
                if (Approved.Month >= 24 && Hours >= 35)
                {
                    total_salary_with_extra = total_salary_without_extra * 1.15f;
                }
                else
                {
                    total_salary_with_extra = total_salary_without_extra * 1.1f;
                }
            }
            total_salary_with_extra = total_salary_with_extra  * ((Feedback * 0.01f + 1) + Pre_Experience * 0.003);
            total_salary_with_extra = Math.Round(total_salary_with_extra, 2);
            
        }

        public override string ToString()
        {
           string bs = String.Format("\nСотрудник: {0} \n   Принят на работу: {1}  \n   Вид деятельности обслуживающ" +
                "его персонала: {2} \n   Возраст: {3} \n   Стаж работы на данном месте (в месяцах): {4} \n   Стаж работы до этой работы на данной специальности (в месяцах): {5} \n   Количество средних отработанных часов за неделю в течение месяца : {6} \n  " +
                " Заработная плата: {7}$ \n   Количество выговоров: {8} \n   Приоритетность выдачи отпускных: {9} \n   Мед.страховка: {10}" +
                " \n   Общая оценка эффективности: {11}.", Surname, Approved, Kind_of_Work, difference, during, Pre_Experience, Hours, total_salary_with_extra, vigovor, vacation, Med_Straxovka, Feedback);
            return bs;
        }
        public void Print()
        {
            Console.WriteLine(this);
        }
    }
}
