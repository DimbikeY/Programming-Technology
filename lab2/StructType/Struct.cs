using System;

namespace StructType
{
    class Struct
    {
        public enum AccountType { Checking, Deposit } // Создали перечисление с типами (аттрибуты)
        public struct BankAccount  // Структура, содержащая следующие поля...
        {
            public long accNo;
            public decimal accBal;
            public AccountType accType;     // *
        }
        static void Main(string[] args)
        {
            BankAccount goldAccount;
            // Присвоим полям переменной goldAccount поля из таблицы *
            goldAccount.accType = AccountType.Checking;
            goldAccount.accBal = (decimal)3200.00;
            Console.WriteLine("Enter account number: ");
            goldAccount.accNo = long.Parse(Console.ReadLine()); // Преобразовали string -> long
            // Выведем на консоль значения каждого из элементов переменной структуры.
            Console.WriteLine("*** Account Summary ***");
            Console.WriteLine("Acct Number {0}", goldAccount.accNo);
            Console.WriteLine("Acct Type {0}", goldAccount.accType);
            Console.WriteLine("Acct Balance ${0}", goldAccount.accBal);
            Console.WriteLine(goldAccount);
        }
    }
}
