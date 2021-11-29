using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_hw
{
    public class Student
    {
        public string Surname { get; set; }
        public string Department { get; set; }
        public DateTime Date_Of_Birthday { get; set; }
        public string Profession { get; set; }
        public double Average_Score { get; set; }
        public double Amount_Debts { get; set; }
        public string Education_type { get; set; }
        public string Number_group { get; set; }


        public double scolarship;
        public string expiration_of_med;
        public DateTime until;

        public DateTime Med_Straxovka { get; set; }


        public Student(string surname, string department, DateTime date_of_birthday, string profession, string number_group, string education_type, DateTime med_straxovka, double average_score, double amount_debts)
        {
            this.Surname = surname;
            this.Department = department;
            this.Date_Of_Birthday = date_of_birthday;
            this.Profession = profession;
            this.Med_Straxovka = med_straxovka;
            this.Average_Score = average_score;
            this.Amount_Debts = amount_debts;
            this.Number_group = number_group;
            this.Education_type = education_type;
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
        public void Basic_Schoolarship()
        {
            switch(Education_type)
            {
                case "Balchelor": scolarship = 450; break;
                case "Master": scolarship = 500; break;
                default: scolarship = 650; break;
            }
        }
        public void Upper_scolarship()
        {
           if (Average_Score == 5 && Amount_Debts == 0)
            {
                scolarship *= 2;
            }
           else if (Average_Score >= 4.5 && Amount_Debts == 0)
            {
                scolarship *= 1.5;
            }
           else if (Average_Score >= 4 && Amount_Debts == 0)
            {
                scolarship *= 1.3;
            }
           else
            {
                scolarship *= 0;
            }
        }
        public override string ToString()
        {
            string bs = String.Format("\nСтудент: {0} || Факультета: {1} \n   Дата Рождения: {2} \n   Специализация: {3} || Группы: {4} \n   Мед.страховка от: {5}" +
                " \n   Время окончания действия страховки: {6} - {7} \n   Тип образования: {8} \n   Средний балл: {9}. Количество долгов: {10}" +
                "\n   Стипендия: {11}$.", Surname, Department, Date_Of_Birthday, Profession, Number_group, Med_Straxovka, until, expiration_of_med, Education_type, Average_Score, Amount_Debts, scolarship);
            return bs;
        }
        public void Print()
        {
            Console.WriteLine(this);
        }
    }
}
