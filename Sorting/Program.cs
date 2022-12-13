using System;
namespace Sorting
{
    public class Program
    {
        public static void Main()
        {
            int[] arr = new int[] { -1, -2, 1, 0, 3, 2, 5, 4 };
            System.Console.WriteLine($"Selection Sort:");
            SelectionSort.Sort(arr);
            System.Console.WriteLine($"Bubble Sort:");
            BubbleSort.Sort(new int[] { -1, -2, 1, 0, 3, 2, 5, 4 });
            System.Console.WriteLine($"Insertion Sort:");
            InsertionSort.Sort(new int[] { -1, -2, 1, 0, 3, 2, 5, 4 });
            System.Console.WriteLine("Merge Sort");
            var input = new int[] { -7,-2, 0,-10, 4,-1, -2, 1, 0, 3, 2, 5, 4 };
            MergeSort.Sort(input, 0, input.Length-1);
            Print.Display(input);
            System.Console.WriteLine("Quick Sort");
            var input2 = new int[] { -5, -7,-2, 0,-10, 4,-1, -2, 1, 0, 3, 2, 5, 4 };
            QuickSort.Sort(input2, 0, input2.Length-1);
            Print.Display(input2);
        }
    }
}


