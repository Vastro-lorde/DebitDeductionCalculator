using CalculatorAssessment.Model;
using CalculatorAssessment.View;
using System;

namespace CalculatorAssessment.BusinessLogic
{
    public class Charges
    {
        public static void AdvisedDebitAmount(ListOfFees fees)
        {
            double amount = 0;
            double charge = 0;
            double transferAmount = 0;
            double debitAmount = 0;
            var Run = true;
            while (Run)
            {
                Console.WriteLine("Please enter amount: ");
                var input = Console.ReadLine();
                if (double.TryParse(input, out double res) && res > 0 && res <= 999999999)
                {
                    amount = res;
                    Run = false;
                }else { Console.WriteLine("Please Input a valid input"); }
            }
           
            foreach (Fee fee in fees.Fees)
            {
                if (Math.Ceiling(amount) >= fee.MinAmount && Math.Ceiling(amount) <= fee.MaxAmount)
                {
                    transferAmount = amount - fee.FeeAmount;
                    charge = fee.FeeAmount;
                    debitAmount = amount;
                }
            }
            PrintTable.MakeDynamicTable(amount, transferAmount, charge, debitAmount);
        }

        public static void ExpectedCharge(ListOfFees fees)
        {
            double amount = 0;
            double result = 0;
            var Run = true;
            while (Run)
            {
                Console.Write("Please enter amount: ");
                var input = Console.ReadLine();
                if (double.TryParse(input, out double res) && res > 0 && res <= 999999999)
                {
                    amount = res;
                    Run=false;
                }
                else {Console.WriteLine("Please Input a valid input"); }
                
            }

            foreach (Fee fee in fees.Fees)
            {
                if (Math.Ceiling(amount) >= fee.MinAmount && Math.Ceiling(amount) <= fee.MaxAmount)
                {
                    result = fee.FeeAmount;
                }
            }
            Console.Write("Expected charge is: ");
            Console.WriteLine(result);
        }
    }
}
