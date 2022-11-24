using System;

namespace ARR_FirstAndLastOccurence
{
    //https://leetcode.com/problems/find-first-and-last-position-of-element-in-sorted-array/submissions/
    class Program
    {
        static void Main(string[] args)
        {
            var input = new int[] { 1, 3, 3, 2, 4, 5, 3, 3, 3, 7, 8, 9, 10 };
            var firstOccurence = FirstOccurence(input, input.Length, 3);
            var lastOccurence = LastOccurence(input, input.Length, 3);

            Console.WriteLine($"[{ firstOccurence} , {lastOccurence}]");
        }

        private static int LastOccurence(int[] arr, int len, int key)
        {

            int s = 0; int e = len - 1;
            int ans = -1;

            while (s <= e)
            {
                int mid = (s + e) / 2;

                if(arr[mid] == key)
                {
                    ans = mid;
                    s = mid + 1;
                } 
                else if(key > arr[mid])
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

        public static int FirstOccurence(int[] arr, int len, int key)
        {
            int s = 0; int e = len - 1;
            int ans = -1;
            //1,3,3,3,4,5,3,3,3,7,8,9,10
            while (s <= e)
            {
                int mid = s + (e-s) / 2;

                if(arr[mid] == key)
                {
                    ans = mid;
                    e = mid - 1;
                }
                else if(key > arr[mid])
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
    }
}
