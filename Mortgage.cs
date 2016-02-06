using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bnak
{
    class Mortgage:Account
    {
        public Mortgage(bool isCustomerCompany, double balance, double interestRate)
            : base(isCustomerCompany, balance, interestRate)
        {
        }
        public override decimal CalculateInterest(uint mount)
        {
            if (IsCustomerCompany == true)
            {
                return CalculateCompanyInterest(mount);
            }
            else
            {
                return CalculateIndivdualInterest(mount);
            }

        }
        private decimal CalculateCompanyInterest(uint mount)
        {
            decimal interest=0.0M;
            uint halfInterestPoriod = 12;
            if (mount <= halfInterestPoriod)
            {
                interest = (decimal)(mount * this.interestRate / 2);
                return interest;
            }
            else
            {
                mount -= halfInterestPoriod;
                interest = (decimal)((halfInterestPoriod*(this.interestRate/2))
                    +( mount * this.interestRate));
                return interest;
            }
        }
        private decimal CalculateIndivdualInterest(uint mount)
        {
            decimal interest = 0.0M;
            uint noPeriodInterest = 6;
            if (mount <= noPeriodInterest)
            {
                return interest;
            }
            else
            {
                mount -= noPeriodInterest;
                interest = (decimal)(mount * this.interestRate);
                return interest;
            }
        }
    }
}
