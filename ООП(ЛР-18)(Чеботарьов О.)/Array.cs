using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ООП_ЛР_18__Чеботарьов_О._
{
    class Program
    {
       static void Main(string[] args)
        {
            int[] numbers = new int[] {1, -2, 3, -1, 20};
            int SumNegative = 0;
            int SumMiddle = 0;
            List<int> filtNum = new List<int>();

            for (int i = 0; i < numbers.Length; i += 1)
            {
                if (numbers[i] < 0)
                {
                    SumNegative += numbers[i];
                }
            }
            for (int i = 1; i < numbers.Length - 1; i++)
            {
                SumMiddle += numbers[i];
            }
            Console.WriteLine("Array #1 elements:");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine("");
            Console.WriteLine("Sum of all negative elements:" + SumNegative);
            Console.WriteLine("Sum of all elements exept first and last ones:" + SumMiddle);

            int[] Newnumbers = new int[] {10, 6, 2, 28, 7};
            Console.WriteLine("Array #2 elements:");
            for (int i = 0; i < Newnumbers.Length; i++)
            {
                Console.Write(Newnumbers[i] + " ");
            }

            int temp;
            for (int i = 0; i < Newnumbers.Length - 1; i++)
            {
                for (int j = i + 1; j < Newnumbers.Length; j++)
                {
                    if (Newnumbers[i] > Newnumbers[j])
                    {
                        temp = Newnumbers[i];
                        Newnumbers[i] = Newnumbers[j];
                        Newnumbers[j] = temp;
                    }
                }
            }
            Console.WriteLine("");
            Console.WriteLine("Filtrated array #2:");
            for (int i = 0; i < Newnumbers.Length; i++)
            {
                Console.Write(Newnumbers[i] + " ");
            }
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            int[,] doublenum = { { 5, 5, 2 }, { 4, 7, 3 } };
            int height = doublenum.GetLength(0);
            int widht = doublenum.GetLength(1);

            Console.WriteLine("Double array elements:");
            for (int y = 0; y < height; y++)
            {
                for(int x = 0;  x < widht; x++)
                {
                    Console.Write(doublenum[y, x] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine(" ");
            int First = doublenum[0, widht - 1];
            int Last = doublenum[height - 1, 0];
            Console.WriteLine("Upper right element of a double array: " + First);
            Console.WriteLine("Down left element of a double array: " + Last);
        }
    }
}
