using System.Diagnostics.Metrics;
using System.Net.NetworkInformation;
using System.Reflection.Metadata.Ecma335;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            #region task1
            Console.WriteLine("Task1");

            int[] arr1 = { 1, 2, 3, 4, 5, 5, 5 };
            int even = 0;
            int[] set = arr1;
            int unic = 0;
            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] % 2 == 0)
                {
                    even++;
                }
                bool k = true;
                for (int i1 = 0; i1 < set.Length; i1++)
                {
                    if (i == i1) continue;
                    if (arr1[i] == set[i1])
                    {
                        k = false;
                        set[i] = 0;
                        break;
                    }
                }
                if (k)
                {
                    unic++;
                }
            }
            Console.WriteLine($"Even: {even}");
            Console.WriteLine($"Odd: {arr1.Length - even}");
            Console.WriteLine($"Unic: {unic}");
            #endregion task1

            #region task2
            Console.WriteLine("Task2");

            int[] arr2 = { 1, 2, 3, 4, 5, 6, 7, 8, 1, 2, 3, 12 };
            Console.Write("Input num: ");
            int.TryParse(Console.ReadLine(), out int inp1);

            int count1 = 0;
            for (int i = 0; i < arr2.Length; i++)
            {
                if (arr2[i] < inp1) count1++;
            }

            Console.WriteLine($"Less then {inp1}: {count1}");

            #endregion task2

            #region task3
            Console.WriteLine("Task3");

            int[] arr3 = { 7, 6, 5, 3, 4, 7, 6, 5, 8, 7, 6, 5 };
            Console.Write("Input num1: ");
            int.TryParse(Console.ReadLine(), out int inp2);
            Console.Write("Input num2: ");
            int.TryParse(Console.ReadLine(), out int inp3);
            Console.Write("Input num3: ");
            int.TryParse(Console.ReadLine(), out int inp4);

            int count2 = 0;
            for (int i = 0; i < arr3.Length - 2; i++)
            {
                if (arr3[i] == inp2 && arr3[i+1] == inp3 && arr3[i+2] == inp4) count2++;
            }

            Console.WriteLine($"Ans: {count2}");

            #endregion task3
            

            #region task4
            Console.WriteLine("Task4");

            int m = 5;
            int n = 5;

            int[] arr4_1 = { 1, 2, 3, 4, 5 };
            int[] arr4_2 = { 3, 4, 5, 6, 7, 8, 9 };

            int[] ans4 = new int[arr4_1.Length + arr4_2.Length];
            int size4 = 0;

            for (int i = 0; i < arr4_1.Length; i++)
            {
                bool k = false;
                for (int j = 0; j < arr4_2.Length; j++)
                {
                    if (arr4_1[i] == arr4_2[j]) { k = true; break; };
                }
                for (int j = 0; j < size4; j++)
                {
                    if (arr4_1[i] == ans4[j]) { k = false; break; }
                }
                if (k)
                {
                    ans4[size4] = arr4_1[i];
                    size4++;
                }
            }
            int[] ans4_1 = new int[size4];
            for (int i = 0; i < size4; i++)
            {
                ans4_1[i] = ans4[i];
            }
            ans4 = ans4_1;
            Console.Write("Ans: ");
            foreach (int i in ans4)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            #endregion task4

            #region task5
            Console.WriteLine("Task5");

            int[,] arr5 = { {1, 2, 3 }, { 2, 3, 4 }, { 4, 5, 6 } };
            int sum5 = 0;

            for (int i = 0; i < arr5.GetLength(0); i++)
            {
                for (int j = 0; j < arr5.GetLength(1); j++)
                {
                    sum5 += arr5[i, j];
                }
            }
            Console.WriteLine($"Sum: {sum5}");
            #endregion task5

            #region task6
            Console.WriteLine("Task6");

            Console.Write("Input string: ");
            string s6 = Console.ReadLine();

            int count6 = 1;
            for (int i = 0; i < s6.Length; i++)
            {
                if (s6[i] == ' ') count6++;
            }
            Console.WriteLine($"Word count: {count6}");

            #endregion task6*/

        }
    }
}
