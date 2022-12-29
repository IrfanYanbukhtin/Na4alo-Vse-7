using System;

namespace Vse_na4alo_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Range a");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Range b");
            int b = int.Parse(Console.ReadLine());
            int digitCount;
            int count = 0;


            for (int i = a; i <= b; i++)
            {
                digitCount = (int)Math.Log10(i);
                int r = i / (int)Math.Pow(10, digitCount);
                if (r == 7)
                    count++;

            }

            int[] sevens = new int[count];
            int index = 0;
            for (int i = a; i <= b; i++)
            {
                digitCount = (int)Math.Log10(i);
                int r = i / (int)Math.Pow(10, digitCount);
                if (r == 7)
                {
                    sevens[count - 1] = i;
                    count--;
                }
            }
            foreach (var item in sevens)
            {
                Console.WriteLine(item);
            }


            //Console.Write("massivin uzunlugu daxil et");
            //int n = int.Parse(Console.ReadLine());
            //int [] arr = new int[n];
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write($"arr[{i}]=");
            //    arr[i] = int.Parse(Console.ReadLine());
            //}
        }
    }
}
