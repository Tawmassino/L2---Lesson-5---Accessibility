using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2___Lesson_5___Accessibility
{
    public class BankAccount
    {   //field
        private double balance;

        //properties
        protected double Balance //propercio backing field yra "balance" is fieldo
        {
            get
            {
                return balance;
            }

            set
            {
                if (value > 0)
                    balance = value; //setterio reiksme yra value
            }
        }

        //constructor
        protected BankAccount(double balance)
        {
            Balance = balance;
        }

        //methods
        protected string PrintBalance()
        {
            return $"The Current balance is : {Balance}";
        }

        public double BalanceUnclock()
        {
            return Balance;
        }

    }

}
