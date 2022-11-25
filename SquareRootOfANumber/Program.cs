using System;

namespace SquareRootOfANumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = FindSquareRootOfWholeNumber(1000000);
        }

        private static long FindSquareRootOfWholeNumber(int num)
        {
            long ans = -1;
            long s = 1;
            long e = num;

            while(s <= e)
            {
                long mid = (s + e) / 2;

                long square =  mid * mid;

                if (square == num) return mid;

                else if(mid * mid > num)
                {
                    e = mid - 1;
                }
                else
                {
                    ans = mid;
                    s = mid + 1;
                }
            }

            return ans;
        }
    }
}
