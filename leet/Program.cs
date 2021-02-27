using System;

namespace leet
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            int[] pushed = new int[] { 1, 2, 3, 4, 5,6};
            int[] popped = new int[] { 5,6, 4, 3, 2, 1 };
            Console.WriteLine("uguale? {0}",s.ValidateStackSequences(pushed,popped));
            Console.ReadKey();
        }
    }
}
