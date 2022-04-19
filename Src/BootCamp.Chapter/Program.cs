using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Print each of the statistical output using Text Table with padding 3:
            // - FindHighestBalanceEver
            // - FindPersonWithBiggestLoss
            // - FindRichestPerson
            // - FindMostPoorPerson
            PeoplesBalances.ArrayPrinter(PeoplesBalances.Balances);
            Console.WriteLine("");
            PeoplesBalances.ArraySplitter(PeoplesBalances.Balances, PeoplesBalances.TomsArray, 0);
            PeoplesBalances.ArraySplitter(PeoplesBalances.Balances, PeoplesBalances.KatherinesArray, 1);
            PeoplesBalances.ArraySplitter(PeoplesBalances.Balances, PeoplesBalances.BillsArray, 2);
            PeoplesBalances.ArraySplitter(PeoplesBalances.Balances, PeoplesBalances.CatiesArray, 3);
        }
    }
}
