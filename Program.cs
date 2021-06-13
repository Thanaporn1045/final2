using System;

namespace ข้อ_2_Return_of_the_Sorts
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int[] num = new int[x];
            for (int i = 0; i < num.Length; i++)
            {
                num[i] = int.Parse(Console.ReadLine());
            }
            first(num); Console.WriteLine();
            second(num); Console.WriteLine();
        }
        static void first(int[] num)
        {
            for (int i = num.Length-1; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    SwapIfHigher(ref num[j], ref num[j + 1]);
                }
            }
            Console.Write("Swapping's sort ");
            for (int k = 0; k < num.Length; k++)
            {
                
                Console.Write(num[k]);
                Console.Write(" ");
            }
        }
        static void Swap(ref int a, ref int b)
        {
            int tmp = a;
            a = b;
            b = tmp;
        }
        static void SwapIfHigher(ref int a, ref int b)
        {
            if (a > b)
            {
                Swap(ref a, ref b);
            }
        }


        static void second(int [] num)
        {
            
                int count, max, j, k;
                for (count = 0; count < num.Length; count++)
                {
                    max = count;
                    for (j = count + 1; j < num.Length; j++)
                    {
                        if (num[max] < num[j])
                            max = j;
                    }
                    if (max != count)
                    {
                        k = num[count];
                    num[count] = num[max];
                    num[max] = k;
                    }
                }
            
            Console.Write("if's sort ");
            for (int x = num.Length-1; x >=0 ; x--)
            {

                Console.Write(num[x]);
                Console.Write(" ");
            }



        }
    }
}
