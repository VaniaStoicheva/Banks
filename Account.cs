using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bnak
{
   
   public abstract class Account
    {
        private bool isCustomerCompany;
        protected double balance;
        protected double interestRate;

        public Account(bool isCustomerCompany, double balance, double interestRate)
        {
            this.isCustomerCompany = isCustomerCompany;
            this.balance = balance;
            this.interestRate = interestRate;
        }
        public bool IsCustomerCompany
        {
            get { return isCustomerCompany; }
            set { this.isCustomerCompany = value; }
        }
        public double Balance
        {
            get { return this.balance; }
        }
        public double InterestRate
        {
            get { return this.interestRate; }
        }

       //methods
        public virtual void Deposit(double amount)
        {
            this.balance+=amount; 
           
        }
        public abstract decimal CalculateInterest(uint mount);
    }
}
