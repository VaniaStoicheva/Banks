using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bnak
{
    class Deposit:Account
    {
        public Deposit(double balance, double interestRate)
            : base(true, balance, interestRate)
        {
        }

        public bool WithDraw(double amount)
        {
            if (amount <= this.balance)
            {
                this.balance-= amount;
                return true;
            }
            else
            {
                return false;
            }
        }
        public override decimal CalculateInterest(uint mount)
        {
            decimal interest=0.0M;
            if (this.balance <= 1000 && this.balance <=0)
            {
                Console.WriteLine("No Interest");
                return interest;
            }
            else
            {
                interest = (decimal)(mount * this.interestRate);
                return interest;
            }
        }
    }
}
