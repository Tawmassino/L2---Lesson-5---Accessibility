using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2___Lesson_5___Accessibility
{
    internal class CheckingAccount : BankAccount
    {
        //field
        //protected double balance;

        //properties
        private double OverdraftLimit { get; set; }
        protected CheckingAccount(double balance, double overdraftLimit) : base(balance)
        {
            OverdraftLimit = overdraftLimit;
        }

        public void Withdraw(double kiekNorimIsimt)//voidinis metodas, nes ne visa balansa norim isimti
        {
            if (BalanceUnclock() >= OverdraftLimit)
            {
                double newBalance = BalanceUnclock();
                newBalance -= kiekNorimIsimt;
                //return BalanceUnclock();
            }
            else { throw new Exception("Not enough money"); }
        }
    }
}
