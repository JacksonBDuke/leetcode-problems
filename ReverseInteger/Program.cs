/*
    Author: Jackson Duke

    Problem     - https://leetcode.com/problems/reverse-integer/description/
    Submission  - https://leetcode.com/submissions/detail/157094855/
    Details
        Status: Accepted
        Submitted: June, 2018
        1032/1032 test cases passed
        Runtime: 52ms
        Notes: "Your runtime beats 41.65 % of csharp submissions."
 */

using System;

namespace ReverseInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1534236469;
            Console.WriteLine(x / 10);
            Console.WriteLine(x % 10);
            Console.WriteLine(Reverse(x));
        }

        public static int Reverse(int x) {
            int ret = 0;
            checked{
                try{
                    while(x != 0){
                        ret = ret * 10 + x % 10;
                        x = x / 10;
                    }
                    return ret;
                }
                catch(OverflowException){
                    return 0;
                }
            }
            
        }
    }
}
