using CalculatorAssessment.BusinessLogic;
using System;

namespace CalculatorAssessment.View
{
    public class Services
    {
        public static async void Start()
        {
            bool Run = true;
            while (Run)
            {
                var fees = await ReadFromJson.FetchFees();
                Charges.ExpectedCharge(fees);
                Charges.AdvisedDebitAmount(fees);
                Console.Write("Chosse 1 to continue or any other key to end: ");
                var choose= Console.ReadLine();
                if (choose != "1") Run = false;
            }
        }
    }
}
