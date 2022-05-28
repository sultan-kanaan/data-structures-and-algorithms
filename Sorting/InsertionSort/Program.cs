using System;

namespace InsertionSort
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;


            int[] random = { 8, 4, 23, 42, 16, 15 };
            int[] reverseSorted = { 20, 18, 12, 8, 5, -2 };
            int[] fewUniques = { 5, 12, 7, 5, 5, 7 };
            int[] nearlySorted = { 2, 3, 5, 7, 13, 11 };

            Console.WriteLine();
            Console.WriteLine("Selection Sort : ");
            Console.WriteLine();

            Console.WriteLine("[ " + string.Join(", ", SelectionSort(random)) + " ]");
            Console.WriteLine("[ " + string.Join(", ", SelectionSort(reverseSorted)) + " ]");
            Console.WriteLine("[ " + string.Join(", ", SelectionSort(fewUniques)) + " ]");
            Console.WriteLine("[ " + string.Join(", ", SelectionSort(nearlySorted)) + " ]");

            Console.WriteLine();
            Console.WriteLine("Insertion Sort : ");
            Console.WriteLine();


            Console.WriteLine("[ " + string.Join(", ", InsertionSort(random)) + " ]");
            Console.WriteLine("[ " + string.Join(", ", InsertionSort(reverseSorted)) + " ]");
            Console.WriteLine("[ " + string.Join(", ", InsertionSort(fewUniques)) + " ]");
            Console.WriteLine("[ " + string.Join(", ", InsertionSort(nearlySorted)) + " ]");

            Console.WriteLine();
            Console.WriteLine("Merge Sort : ");
            Console.WriteLine();


            Console.WriteLine("[ " + string.Join(", ", MergeSort(random)) + " ]");
            Console.WriteLine("[ " + string.Join(", ", MergeSort(reverseSorted)) + " ]");
            Console.WriteLine("[ " + string.Join(", ", MergeSort(fewUniques)) + " ]");
            Console.WriteLine("[ " + string.Join(", ", MergeSort(nearlySorted)) + " ]");




            Console.ReadKey();
        }
        public static int[] SelectionSort(int[] arr)
        {
            int n = arr.Length;

            for (int i = 0; i < n - 1; i++)
            {
                int min = i;

                for (int j = i + 1; j < n; j++)
                    if (arr[j] < arr[min])
                        min = j;

                int temp = arr[min];
                arr[min] = arr[i];
                arr[i] = temp;
            }

            return arr;
        }
        public static int[] InsertionSort(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                int j = i - 1;
                int temp = arr[i];

                while (j >= 0 && temp < arr[j])
                {
                    arr[j + 1] = arr[j];
                    j -= 1;
                }

                arr[j + 1] = temp;
            }

            return arr;
        }
        public static int[] MergeSort(int[] arr)
        {
            int n = arr.Length;

            if (n > 1)
            {
                int mid = n / 2;
                int[] left = new int[mid];
                int[] right = new int[n - mid];

                for (int i = 0; i < n; i++)
                {
                    if (i < mid)
                    {
                        left[i] = arr[i];
                    }
                    else
                    {
                        right[i - mid] = arr[i];
                    }
                }

                MergeSort(left);
                MergeSort(right);
                Merge(left, right, arr);
            }

            return arr;
        }
        static void Merge(int[] left, int[] right, int[] arr)
        {
            int i = 0;
            int j = 0;
            int k = 0;

            while (i < left.Length && j < right.Length)
            {
                if (left[i] <= right[j])
                {
                    arr[k] = left[i];
                    i++;
                }
                else
                {
                    arr[k] = right[j];
                    j++;
                }
                k++;
            }

            if (i == left.Length)
            {
                while (j < right.Length)
                {
                    arr[k] = right[j];
                    j++;
                    k++;
                }
            }
            else
            {
                while (i < left.Length)
                {
                    arr[k] = left[i];
                    i++;
                    k++;
                }

            }
        }
    }
}
