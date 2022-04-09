namespace BootCamp.Chapter1
{
    internal class Program
    {
        public static int[] numberList = { 5, 9, 4, 8, 3, 7 };
        public static int[] newNumberListFirstRemoved = new int[numberList.Length - 1];
        public static int[] newNumberListSpecificRemoved = new int[numberList.Length-1];
        public static int[] newNumberListAddedFirst = new int[numberList.Length + 1];
        public static int[] newNumberListAddedLast = new int[numberList.Length + 1];
        public static int[] newNumberListAddedSpecific = new int[numberList.Length + 1];

        public static int indexToRemove = 3;
        
        public static int intToAdd = 46;
        public static int elementFirstPosition = 0;
        public static int elementLastPosition = newNumberListAddedLast.Length - 1;
        public static int elementSpecificPosition = 2;

        private static void Main(string[] args)
        {
            ArrayOperations.Sort(numberList);
            ArrayOperations.Reverse(numberList);
            ArrayOperations.RemoveLast(numberList);
            ArrayOperations.RemoveFirst(numberList, newNumberListFirstRemoved);
            ArrayOperations.RemoveAt(numberList, newNumberListSpecificRemoved, indexToRemove);
            ArrayOperations.InsertFirst(numberList, newNumberListAddedFirst, elementFirstPosition, intToAdd);
            ArrayOperations.InsertLast(numberList, newNumberListAddedLast, intToAdd);
            ArrayOperations.InsertAt(numberList, newNumberListAddedSpecific, elementSpecificPosition, intToAdd);
        }
    }

}