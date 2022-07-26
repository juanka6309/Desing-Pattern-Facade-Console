
namespace ConsoleFacade.Utils
{
    static class Print
    {
        static int tableWidth = 75;

        static public void PrintHeader()
        {
            PrintLine();
            PrintRow("Description", "Amount", "Price Bs.");
            PrintLine();
        }

        static public void PrintFooter(double total)
        {
            PrintLine();
            PrintRow("Total", "", total.ToString("0.00"));
            PrintLine();
        }
        static public void PrintLine()
        {
            Console.WriteLine(new string('-', tableWidth));
        }

        static public void PrintRow(params string[] columns)
        {
            int width = (tableWidth - columns.Length) / columns.Length;
            string row = "|";

            foreach (string column in columns)
            {
                row += AlignCentre(column, width) + "|";
            }

            Console.WriteLine(row);
        }

        static public string AlignCentre(string text, int width)
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
    }
}
