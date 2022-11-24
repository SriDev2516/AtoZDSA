using System;

namespace ARR_PeakIndexInAnMountainArray
{
    class Program
    {
        //https://leetcode.com/problems/peak-index-in-a-mountain-array/

        static void Main(string[] args)
        {
            FindPeakInArray(new int[] { 1, 2, 5, 4, 3, 1 });
        }

        private static void FindPeakInArray(int[] vs)
        {
            int s = 0;
            int e = vs.Length - 1;

            while(s < e)
            {
                int mid = (s + e) / 2;
                if(vs[mid] < vs[mid + 1])
                {
                    s = mid + 1;
                }
                else
                {
                    e = mid;
                }
            }

            Console.WriteLine(s);
        }
    }
}
