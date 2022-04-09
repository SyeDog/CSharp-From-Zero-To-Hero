using System;
using System.Runtime;
using System.Linq;

namespace BootCamp.Chapter1
{
    public static class ArrayOperations
    {
        /// <summary>
        /// Sort the array in ascending order.
        /// If array empty or null- don't do anything.
        /// </summary>
        /// <param name="array">Input array in a random order.</param>
        public static void Sort(int[] array)
        {
            // ToDo: implement.
            ArrayChecker(array);
            Array.Sort(array);
            Console.Write("Sorted Array in ascending order: ");
            ArrayPrinter(array);
            Console.WriteLine(" ");


        }

        /// <summary>
        /// Reverse the array elements, first being last and so on.
        /// If array empty or null- don't do anything.
        /// </summary>
        /// <param name="array">Input array in a random order.</param>
        public static void Reverse(int[] array)
        {
            // ToDo: implement.
            ArrayChecker(array);
            Array.Reverse(array);
            Console.Write("Sorted Array in Descending order: ");
            ArrayPrinter(array);
            Console.WriteLine(" ");

        }

        /// <summary>
        /// Remove last element in array.
        /// </summary>
        /// <param name="array">Input array.</param>
        /// <returns>A new array with the last element removed. If an array is empty or null, returns input array.</returns>
        public static void RemoveLast(int[] array)
        {
            // ToDo: implement.
            ArrayChecker(array);
            Array.Resize(ref array, array.Length - 1);
            Console.Write("Array with removed last integer: ");
            ArrayPrinter(array);
            Console.WriteLine(" ");
        }

        /// <summary>
        /// Remove first element in array.
        /// </summary>
        /// <returns>A new array with the first element removed. If an array is empty or null, returns input array.</returns>
        public static void RemoveFirst(int[] array, int[] newArray)
        {
            // ToDo: implement.
            ArrayChecker(array);
            IndexRemoverFirst(array, newArray);
            Console.Write("Array with removed first integer: ");
            ArrayPrinter(newArray);
            Console.WriteLine(" ");

        }

        /// <summary>
        /// Removes array element at given index.
        /// </summary>
        /// <param name="array">Input array.</param>
        /// <param name="index">Index at which array element should be removed.</param>
        /// <returns>A new array with element removed at a given index. If an array is empty or null, returns input array.</returns>
        public static void RemoveAt(int[] array, int[] newArray, int index)
        {
            // ToDo: implement.
            ArrayChecker(array);
            IndexRemoverSpecific(array, newArray, index);
            Console.Write("Array with removed Specific integer of " + Program.indexToRemove.ToString());
            ArrayPrinter(newArray);
            Console.WriteLine(" ");
        }

        /// <summary>
        /// Inserts a new array element at the start.
        /// </summary>
        /// <param name="array">Input array.</param>
        /// <param name="number">Number to be added.</param>
        /// <returns>A new array with element added at a given index. If an array is empty or null, returns new array with number in it.</returns>
        public static void InsertFirst(int[] array, int[] newArray, int index, int number)
        {
            // ToDo: implement.
            ArrayChecker(array);
            IndexAdderToPosition(array, newArray, index, number);
            Console.Write("Array with index added to First Position: ");
            ArrayPrinter(newArray);
            Console.WriteLine(" ");
        }

        /// <summary>
        /// Inserts a new array element at the end.
        /// </summary>
        /// <param name="array">Input array.</param>
        /// <param name="number">Number to be added.</param>
        /// <returns>A new array with element added in the end of array. If an array is empty or null, returns new array with number in it.</returns>
        public static void InsertLast(int[] array, int[] newArray, int number)
        {
            // ToDo: implement.
            ArrayChecker(array);
            IndexAdderToLastPosition(array, newArray, number);
            Console.Write("Array with index added to Last Position: ");
            ArrayPrinter(newArray);
            Console.WriteLine(" ");
        }

        /// <summary>
        /// Inserts a new array element at the specified index.
        /// </summary>
        /// <param name="array">Input array.</param>
        /// <param name="number">Number to be added.</param>
        /// <param name="index">Index at which array element should be added.</param>
        /// <returns>A new array with element inserted at a given index. If an array is empty or null, returns new array with number in it.</returns>
        public static void InsertAt(int[] array, int[] newArray, int index, int number)
        {
            // ToDo: implement.
            ArrayChecker(array);
            IndexAdderToSpecificPosition(array, newArray, index, number);
            Console.Write("Array with index added to specific index of " + Program.elementSpecificPosition.ToString());
            ArrayPrinter(newArray);
            Console.WriteLine(" ");

        }

        public static int[] ArrayChecker(int[] array)
        {
            if (array == null || array.Length == 0)
            {
                Console.WriteLine("ERROR: Array was either Null or Empty");
                return null;
            }
            else
            {
                Console.Write("Input Array is: ");
                ArrayPrinter(array);
                return array;
            }
        }


        public static int[] ArrayPrinter(int[] array)
        {
            Console.WriteLine("[{0}]", string.Join(", ", array));
            return array;
        }

        public static int[] IndexRemoverFirst(int[] array, int[] newArray)
        {
            Array.Copy(array, 1, newArray, 0, array.Length - 1);
            return newArray;
        }

        public static int[] IndexRemoverSpecific(int[] array, int[] newArray, int IndexToRemoveFromArray)
        {
            newArray = array.Where(x => x != IndexToRemoveFromArray).ToArray();
            return newArray;
        }

        public static int[] IndexAdderToPosition(int[] array, int[] newArray, int indexWhereElementAdded, int elementToAdd)
        {
            for (int i = 0; i < newArray.Length; i++)
            {
                if (i < indexWhereElementAdded) newArray[i] = array[i];
                else if (i == indexWhereElementAdded) newArray[i] = elementToAdd;
                else newArray[i] = array[i - 1];
            }
            return newArray;
        }

        public static int[] IndexAdderToLastPosition(int[] array, int[] newArray, int elementToAdd)
        {
            int lastPosition = newArray.Length - 1;
            for (int i = 0; i < newArray.Length; i++)
            {
                if (i < newArray.Length - 1) newArray[i] = array[i];
                else if (i == lastPosition) newArray[i] = elementToAdd;
                else return newArray;
            }
            return newArray;
        }

        public static int[] IndexAdderToSpecificPosition(int[] array, int[] newArray, int indexWhereElementAdded, int elementToAdd)
        {
            for (int i = 0; i < newArray.Length; i++)
            {
                if (indexWhereElementAdded > newArray.Length - 1)
                {
                    Console.WriteLine("Error, your entered index is larger than the array length");
                    return newArray;
                }
                else if (i < indexWhereElementAdded) newArray[i] = array[i];
                else if (i == indexWhereElementAdded) newArray[i] = elementToAdd;
                else newArray[i] = array[i - 1];
            }
            return newArray;
        }
    }
}
