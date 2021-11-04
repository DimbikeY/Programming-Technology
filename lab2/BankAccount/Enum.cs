using System;

namespace BankAccount
{
    
    class Enum
    {
        public enum AccountType { Checking, Deposit }
        static void Main(string[] args)
        {
            AccountType goldAccount;
            AccountType platinumAccount;
            goldAccount = AccountType.Checking;
            platinumAccount = AccountType.Deposit;
            Console.WriteLine("The Customer Account Type is {0}.", goldAccount);
            Console.WriteLine("The Customer Account Type is {0}.", platinumAccount);

        }
    }
}
