using System;

namespace Next_Permutation
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = new int[] { 5, 6, 9, 8, 2, 1 };
            NextPermutation(nums);
            Console.WriteLine(string.Join(",", nums));
        }

        // https://www.youtube.com/watch?v=LuLCLgMElus
        static void NextPermutation(int[] nums)
        {
            if (nums == null || nums.Length == 1) return;
            int i = nums.Length - 2; // second last element
            // check from the end for decending order until the chain breaks
            // eg - 5 ,6 , 9 , 8, 2 , 1
            while (i >= 0 && nums[i] >= nums[i + 1]) i--;
            if (i >= 0)
            {
                // find the smallest element from 9,8,2,1 which is greater than 6.
                int j = nums.Length - 1;
                while (j >= 0 && nums[i] >= nums[j]) j--;
                Swap(nums, i, j);
                // after swap array - 5, 8, 9, 6, 2, 1
                // after that sort the 9, 6, 2 ,1 in asc order
                Reverse(nums, i + 1, nums.Length - 1);
            }
        }

        static void Swap(int[] nums, int i , int j)
        {
            int temp = nums[i];
            nums[i] = nums[j];
            nums[j] = temp;
        }

        static void Reverse(int[] nums, int i , int j)
        {
            while (i < j) Swap(nums, i++, j--);
        }
    }
}
