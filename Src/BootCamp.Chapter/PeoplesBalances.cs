

namespace BootCamp.Chapter
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Text;



    /// <summary>
    /// Part 2.
    /// </summary>
    public static class PeoplesBalances
    {
        /// <summary>
        /// Here are people and their balances.
        /// One line = one person.
        /// Line is made by name (no spaces), follow by balances separated by comma (",").
        /// Example: "Gily, 1, 0". Means that currently Gily has 0, which dropped from initial 1.
        /// </summary>
        public static string[] Balances => new[]
        {
            "Tom, 15.5, 200, 500, 600, 200, 500, 1000",
            "Katherine, 85, 0, -500, 0, 500, 10000, 1500.99",
            "Bill, 99999, 0, 99970, 99900",
            "Catie, 0, 500, 990, 1300"
        };

        public static string[] TomsArray = new string[8];
        public static string[] KatherinesArray = new string[8];
        public static string[] BillsArray = new string[4];
        public static string[] CatiesArray = new string[4];

        public static string[] TomsBalanceArray = new string[8];


        public static Array ArraySplitter(Array oldArray, Array NewArray, int IndexToSplit)
        {
            NewArray = Balances[IndexToSplit].Split(", ");
            ArrayPrinter(NewArray);
            Console.WriteLine(" ");
            return NewArray;
        }

        public static void ArrayPrinter(Array inputArray)
        {
            foreach (var item in inputArray)
            {
                Console.Write(item.ToString());
                Console.WriteLine("");
            }
        }
    }
}
