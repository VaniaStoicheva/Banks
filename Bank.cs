using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bnak
{
    class Bank
    {
        public static void Main()
        {
            Console.WriteLine(ReadAccount());
        }

        private static string ReadAccount()
        {
            int n = int.Parse(Console.ReadLine());
            StringBuilder result = new StringBuilder();
            for (int currAcc = 0; currAcc < n; currAcc++)
            {
                string account = Console.ReadLine();
                string interest = IdentifyAccount(account);
                result.Append(interest);
            }
            return result.ToString();
        }

        private static string IdentifyAccount(string account)
        {
                string[] splitedAccount = account.Split();
                string detail = splitedAccount[0] + " " + splitedAccount[1];
                double balance = double.Parse(splitedAccount[2]);
                double interestRates = double.Parse(splitedAccount[3]);
                uint numberMount = uint.Parse(splitedAccount[4]);
                string output = String.Empty;

                switch (detail)
                {
                    case "deposit company":
                    case "deposit individual":
                        output = GetDepositRate(balance, interestRates, numberMount);
                        break;
                    case "loan company":
                        output = GetLoanCompany(balance, interestRates, numberMount);
                        break;
                    case "loan individual":
                        output = GetLoanIndividual(balance, interestRates, numberMount);
                        break;
                    case "mortgage company":
                        output = GetMortgageCompany(balance, interestRates, numberMount);
                        break;
                    case "mortgage individual":
                        output = GetMortgageIndividual(balance, interestRates, numberMount);
                        break;
                    default:
                        {
                            throw new ArgumentException("Incorrect account");
                            //break;
                        }
                 }
                return output;
        }

        private static string GetMortgageIndividual(double balance, double interestRate, uint numberMount)
        {
            Mortgage mortgage = new Mortgage(false,balance,interestRate);
            decimal rate = mortgage.CalculateInterest(numberMount);
            return String.Format("{0:F2}",rate+Environment.NewLine);
        }

        private static string GetMortgageCompany(double balance, double interestRate, uint numberMount)
        {
            Mortgage mortgage = new Mortgage(true, balance, interestRate);
            decimal rate = mortgage.CalculateInterest(numberMount);
            return String.Format("{0:F2}",rate+Environment.NewLine);
        }

        private static string GetLoanIndividual(double balance, double interestRate, uint numberMount)
        {
            Loan loanIndividual = new Loan(false,balance,interestRate);
            decimal rate = loanIndividual.CalculateInterest(numberMount);
            return String.Format("{0:F2}",rate+Environment.NewLine);
        }

        private static string GetDepositRate(double balance, double interestRate, uint numberMount)
        {
            Deposit deposit = new Deposit(balance,interestRate);
            decimal rate = deposit.CalculateInterest(numberMount);
            return String.Format("{0:F2}",rate+Environment.NewLine);
        }

        private static string GetLoanCompany(double balance, double interestRate, uint numberMount)
        {
            
            Loan loanCompany = new Loan(true,balance,interestRate);
            decimal rate=loanCompany.CalculateInterest(numberMount);
            return String.Format("{0:F2}", rate+Environment.NewLine);
        }
    }
}
