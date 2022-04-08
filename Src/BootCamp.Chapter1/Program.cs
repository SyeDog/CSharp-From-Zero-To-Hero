namespace BootCamp.Chapter1
{
    internal class Program
    {
        public static int[] numberList = { 5, 9, 4, 8, 3, 7 };
        public static int[] newNumberListFirstRemoved = new int[numberList.Length - 1];

        private static void Main(string[] args)
        {
            ArrayOperations.Sort(numberList);
            ArrayOperations.Reverse(numberList);
            ArrayOperations.RemoveLast(numberList);
            ArrayOperations.RemoveFirst(numberList, newNumberListFirstRemoved);
        }
    }

}