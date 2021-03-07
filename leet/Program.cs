using System;

namespace leet
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            int[] pushed = new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
            int[] popped = new int[] { 5,6, 4, 3, 2, 1 };
            Console.WriteLine("max? {0}",s.LengthOfLastWord("a "));
            Console.ReadKey();
        }
    }
}
