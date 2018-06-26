using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_12
{
    class Program
    {
        static void BubbleSort(int[] arr)
        {
            int compare = 0;
            int forw = 0;
            for (int i = 0; i < arr.Length; i++)
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    compare++;
                    if (arr[j] > arr[j + 1])
                    {
                        forw ++;
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            Console.WriteLine("Сравнений в сортировке пузырьком: {0}", compare);
            Console.WriteLine("Пересылок в сортировке пузырьком: {0}", forw);
        }

        static void BinTreeSort(int[] arr)
        {
            int compare = 0, forw = 0;
            arr = BinTree.FindTree(arr, out compare, out forw);
            Console.WriteLine("Сравнений в сортировке с помощью двоичного дерева: {0}", compare);
            Console.WriteLine("Пересылок в сортировке с помощью двоичного дерева: {0}", forw);

        }

        static void Main(string[] args)
        {
            Random a = new Random();
            int[] masUp1 = new int[1000];
            int[] masUp2 = new int[1000];
            int[] masDown1 = new int[1000];
            int[] masDown2 = new int[1000];
            int[] masChaos1 = new int[1000];
            int[] masChaos2 = new int[1000];

            for (int i = 0; i < 1000; i++)
            {
                masUp1[i] = i;
                masUp2[i] = i;
                masDown1[i] = 1000 - i;
                masDown2[i] = 1000 - i;
                masChaos1[i] = a.Next(1000);
                masChaos2[i] = masChaos1[i];
            }

            Console.WriteLine("Сортировка массива упорядоченного по возрастанию");
            BubbleSort(masUp1);
            BinTreeSort(masUp2);

            Console.WriteLine();
            Console.WriteLine("Сортировка массива упорядоченного по убыванию");
            BubbleSort(masDown1);
            BinTreeSort(masDown2);

            Console.WriteLine();
            Console.WriteLine("Сортировка неупорядоченного массива");
            BubbleSort(masChaos1);
            BinTreeSort(masChaos2);
            Console.ReadLine();
        }
    }
}
