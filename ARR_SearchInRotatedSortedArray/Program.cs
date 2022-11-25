using System;

namespace ARR_SearchInRotatedSortedArray
{
    class Program
    {
       // https://leetcode.com/problems/search-in-rotated-sorted-array/
        static void Main(string[] args)
        {
            int pivotIndex = -1;
            int target = 3;
            var nums = new int[] { 3,1 };
            pivotIndex =  FindPivotElement(nums);

            int result = FindIndexOfTarget(nums, pivotIndex, target);

            Console.WriteLine(result);
        }

        private static int FindIndexOfTarget(int[] nums, int pivotIndex, int target)
        {
            int ans = -1;
            int s = -1;
            int e = -1;
            if (nums[pivotIndex] <= target &&  target <= nums[nums.Length - 1])
            {
                s = pivotIndex;
                e = nums.Length - 1;
            }
            else
            {
                s = 0;
                e = pivotIndex - 1;
            }

            while(s <= e)
            {
                int mid = (s + e) / 2;

                if (target == nums[mid]) return mid;

                else if(target > nums[mid])
                {
                    s = mid + 1;
                }
                else
                {
                    e = mid - 1;
                }
            }

            return ans;
        }

        private static int FindPivotElement(int[] nums)
        {
            int ans = -1;
            if (nums.Length <= 0) return ans;

            int s = 0;
            int e = nums.Length - 1;

            while(s < e)
            {
                int mid = (s + e) / 2;

                if(nums[mid] >= nums[0])
                {
                    s = mid + 1;
                }
                else
                {
                    e = mid;
                }
            }

            return e;
        }
    }
}
