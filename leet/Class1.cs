using System;
using System.Collections;
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
            Array.Sort(nums);
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

        
  public class ListNode {
      public int val;
      public ListNode next;
      public ListNode(int val=0, ListNode next=null) {
          this.val = val;
          this.next = next;
      }
  }
 
          public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
            {
            return new ListNode(0, null);
            }
        public bool IsPalindrome(int x)
        {
            string sInt = x.ToString();
            for(int i=0;i<sInt.Length;i++)
            {
                if (sInt[i] != sInt[sInt.Length - 1 - i])
                    return false;

            }
            return true;
         }

        public bool IsPalindrome(ListNode head)
        {
            ArrayList al= new ArrayList();
            if (head == null) return true;
            do
            {
                al.Add(head.val);
                head = head.next;
            } 
            while (head != null);

            int[] sInt = (int[])al.ToArray(typeof(int));
            
            for (int i = 0; i < sInt.Length; i++)
            {
                if (sInt[i] != sInt[sInt.Length - 1 - i])
                    return false;

            }
            return true;
        }
        public int MaxSubArray(int[] nums)
        {
            int max = Int32.MinValue;
            int cumMax = Int32.MinValue;
            
            for (int i = 0; i < nums.Length; i++)
            {
                cumMax= 0;
                
                
                for (int j = i; j < nums.Length; j++)
                {

                    //Console.WriteLine("j:{0} nums: {1}", j, nums[j]);
                    cumMax += nums[j];
                    if (cumMax > max) max = cumMax;

                }
                //Console.WriteLine("i{0};max{1};cuMAx{2}",i, max, cumMax);

               
            }
            return max;               
         }
        public int LengthOfLastWord(string s)
        {
            int l = 0;
            string[] sArray= s.Split(' ',StringSplitOptions.RemoveEmptyEntries);
            if (sArray.Length > 0)
                l = sArray[sArray.Length - 1].Length;
            return l;
         }
    }
}
