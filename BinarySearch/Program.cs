/*
    Author: Jackson Duke

    Problem     - https://leetcode.com/problems/binary-search/
    Submission  - https://leetcode.com/submissions/detail/164508803/
    Details
        Status: Accepted
        Submitted: July 18, 2018
        46/46 test cases passed
        Runtime: 156 ms
        Notes: "Your runtime beats 91.19 % of csharp submissions."
 */

using System;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] testCases = new int[][]{
                new int[]{ 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10},
                new int[]{ -10, -7, 2, 3, 8, 20, 35, 386, 2458}
            };

            // new int[]{ 0, 1, 2, 3, 4], 5, 6, 7, 8, 9, 10},
            int targetNumber = 5;

            for(int i = 0; i < testCases.Length; ++i){
                Console.WriteLine("TestCase " + i + " contains " + targetNumber + " at index " + Search(testCases[i], targetNumber));
            }

            // [0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10]
        }

        public static int Search(int[] nums, int target) {
            int currentPosition = ( nums.Length - 1 ) / 2;
            int leftBound = 0;
            int rightBound = nums.Length - 1;
            
            if(target == nums[0]) return 0;
            else if(target == nums[nums.Length - 1]) return nums.Length - 1;
            else{
                while(leftBound <= rightBound){
                    int currentNumber = nums[currentPosition];
                    Console.Write(currentNumber + " " );
                    if(currentNumber == target) return currentPosition;
                    else{
                        if(target > currentNumber){
                            leftBound = ++currentPosition;
                            currentPosition += (rightBound - leftBound) / 2;
                        }
                        else if(target < currentNumber){
                            rightBound = --currentPosition;
                            currentPosition -= (rightBound - leftBound) / 2;
                        }
                    }
                }
            }
            
            return -1;
        }
    }
}
