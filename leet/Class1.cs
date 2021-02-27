using System;
using System.Collections.Generic;
using System.Text;

namespace leet
{
    public class Solution
    {
        public bool ValidateStackSequences(int[] pushed, int[] popped)
        {
            int l = 0;

            if ((pushed.Length != popped.Length)) return false;
            if ((l = pushed.Length) == 0) return true;
            if (l == 1) return pushed[0] == popped[0];

            for (int i = 0; i < l - 2; i++)
            {
                Console.WriteLine("pushed:{0} popped:{1}", pushed[i], popped[l - 1 - i]);
                if (pushed[i] != popped[l - 1 - i]) return false;

            }
            if (l > 2)
                return (pushed[l - 2] == popped[0]) && (pushed[l - 1] == popped[1]);
            else
                return true;
        }
        public int[] TwoSum(int[] nums, int target)
        {
            int[] results=new int[2];
            if (nums.Length < 2) return new int[0];
            for( int idx1=0;idx1<nums.Length;idx1++)
            {
                results[0] = idx1;
                for(int idx2=0;idx2<nums.Length;idx2++)
                {
                    if (idx1!=idx2)
                    {
                        if (target-nums[idx2]==nums[idx1])
                        {
                            results[1] = idx2;
                            return results;
                        }
                    }
                }

            }
            return results;
        }
    }
}
