using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2___Lesson_5___Accessibility
{
    internal class SavingsAccount : BankAccount
    {   //field
        //prop
        protected double balance;
        private double InterestRate { get; set; }
        //construct

        protected SavingsAccount(double balance, double interestRate) : base(balance) //paveldime ir padarome protected
        {
            InterestRate = interestRate;
        }
        //method

        public double CalculateInterest()
        {
            double balanceWithAddedInterest;
            balanceWithAddedInterest = InterestRate + BalanceUnclock();
            return balanceWithAddedInterest;
        }
    }
}
