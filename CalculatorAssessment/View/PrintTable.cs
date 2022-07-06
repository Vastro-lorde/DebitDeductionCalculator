using System;

namespace CalculatorAssessment.View
{
    public class PrintTable
    {
        public static int tableWidth = 100;

        public static void PrintLine()
        {
            Console.WriteLine(new string('-', tableWidth));
        }

        public static void PrintRow(params string[] columns)
        {
            int width = (tableWidth - columns.Length) / columns.Length;
            string row = "|";

            foreach (string column in columns)
            {
                row += MakeTextCenter(column, width) + "|";
            }

            Console.WriteLine(row);
        }

        public static string MakeTextCenter(string text, int width)
        {
            text = text.Length > width ? text.Substring(0, width - 3) + "..." : text;

            if (string.IsNullOrEmpty(text))
            {
                return new string(' ', width);
            }
            else
            {
                return text.PadRight(width - (width - text.Length) / 2).PadLeft(width);
            }
        }
        public static void MakeDynamicTable(double amount, double transferAmount, double charge, double debitAmount)
        {
            PrintTable.PrintLine();
            PrintTable.PrintRow("AMOUNT", "TRANSFER AMOUNT", "CHARGE", "DEBIT AMOUNT(TRANSFER AMOUNT + CHARGE)");
            PrintTable.PrintRow(amount.ToString(), transferAmount.ToString(), charge.ToString(), debitAmount.ToString());
            PrintTable.PrintLine();
            PrintTable.PrintLine();
        }
    }
}
