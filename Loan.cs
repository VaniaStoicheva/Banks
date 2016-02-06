using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bnak
{
    class Loan:Account
    {
        public Loan(bool isCustomerCompany, double balance, double interestRate)
            : base(isCustomerCompany, balance, interestRate)
        {
        }

        public override decimal CalculateInterest(uint mount)
        {
            byte noInterestPeroidOfMounts = 0;
            if (this.IsCustomerCompany == true)
            {
                noInterestPeroidOfMounts = 2;
            }
            else
            {
                noInterestPeroidOfMounts=3;
            }

            decimal interest = 0.0M;
            if (mount <= noInterestPeroidOfMounts)
            {
                return interest;
            }
            else
            {
                mount -= noInterestPeroidOfMounts;
                interest = (decimal)(mount * this.interestRate);
                return interest;
            }
           
            }
        }
    }

