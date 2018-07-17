/*
    Author: Jackson Duke

    Problem     - https://leetcode.com/problems/two-sum/
    Submission  - https://leetcode.com/submissions/detail/164190770/
    Details
        Status: Accepted
        Submitted: July 16, 2018
        20/20 test cases passed
        Runtime: 292ms
        Notes: "Your runtime beats 90.30 % of csharp submissions."
 */

using System;
using System.Collections;

namespace TwoSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] testCases = new int[][]{
                new int[] { 1, 3, 5, 9 , 11, 13, 15, 17 },
                new int[] { 0, 2, 5, 35, 3, -9, 405, 8, 42 },
                new int[] { 3, 2, 4 }
            };

            int[] testTargets = new int[]{
                2, 4, 5, 10, 13, 359, 41, 12, 6
            };

            for(int i = 0; i < testTargets.Length; ++i){
                for(int j = 0; j < testCases.Length; ++j){
                    int[] solution = TwoSum(testCases[j], testTargets[i]);
                    Console.WriteLine("TestCase " + j + " includes " + testTargets[i] + " at indexes [" + solution[0] + ", " + solution[1] + "]");
                }
            }
            // int[] temp = TwoSum(testCases[2], testTargets[8]);
            // Console.WriteLine("Target: " + testTargets[8] + " - " + temp[0] + ", " + temp[1]);
        }

        public static int[] TwoSum(int[] nums, int target) {
            int[] ret = new int[2] { -1, -1};
            
            Hashtable hash = new Hashtable();

            for(int i = 0; i < nums.Length; ++i) {
                int tempToAdd = target - nums[i];

                if(!hash.ContainsKey(tempToAdd)) {

                    hash.Add(tempToAdd, i);
                }
            }

            for(int i = 0; i < nums.Length; ++i) {
                if(hash.ContainsKey(nums[i]) && (i != (int) hash[nums[i]])) {
                    
                    ret = new int[] {i, (int) hash[nums[i]]};                        
                    return ret;
                }
            }

            return ret;
        }
    }
}
