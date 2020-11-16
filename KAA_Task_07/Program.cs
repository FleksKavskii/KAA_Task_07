using System;

namespace KAA_Task_07
{
    class Program
    {
        private static void Shuffle(int[] arr)
        {
            Random rnd = new Random();
            for (int i = 0; i < 100; i++)
            {
                var rndInd = rnd.Next(0, arr.Length);
                var rndInd2 = rnd.Next(0, arr.Length);
                var temp = arr[rndInd];
                arr[rndInd] = arr[rndInd2];
                arr[rndInd2] = temp;
            }
        }

        private static void Main(string[] args)
        {
            var a = new[] { 1, 22, 3, 4, 5, 9, 8, 24, 38, 1, 54, 63, 2 };
            Shuffle(a);
            Console.WriteLine(string.Join(" ", a));
            Console.ReadKey();
        }

    }
}
