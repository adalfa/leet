using System;

namespace leet
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            int[] pushed = new int[] { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 };
            int[] popped = new int[] { 5,6, 4, 3, 2, 1 };
            Console.WriteLine("max? {0}",s.PlusOne(pushed));
            Console.ReadKey();
        }
    }
}
