/*
    Author: Jackson Duke

    Problem     - https://leetcode.com/problems/longest-palindromic-substring/
    Submission  - https://leetcode.com/submissions/detail/156004788/
    Details
        Status: Accepted
        Submitted: June, 2018
        94/94 test cases passed
        Runtime: 228ms
        Notes: "Your runtime beats 33.66 % of csharp submissions."
 */

using System;

namespace LongestPalindromicSubstring
{
    class Program
    {
        static void Main(string[] args)
        {
            string testCase = "bananas";
            string testCase2 = "aaaaasaaaaaa";
            Console.WriteLine(LongestPalindrome(testCase));
            Console.WriteLine(LongestPalindrome(testCase2));
        }
        public static string LongestPalindrome(string s){

            string longestPalindrome = "";
            string temporaryPalindrome = "";
            int leftIndex, rightIndex, tempRightIndex;
            leftIndex = rightIndex = tempRightIndex = 0;

            while(rightIndex < s.Length){
                while(rightIndex < s.Length && s[leftIndex] == s[rightIndex]){
                    temporaryPalindrome = s.Substring(leftIndex, (1 + rightIndex - leftIndex));
                    ++rightIndex;
                }

                if(leftIndex > 0) --leftIndex;
                tempRightIndex = rightIndex;
                
                while((leftIndex >= 0 && tempRightIndex < s.Length) && s[leftIndex] == s[tempRightIndex]){
                    temporaryPalindrome = s.Substring(leftIndex, (1 + tempRightIndex - leftIndex));
                    ++tempRightIndex;
                    --leftIndex;
                }

                leftIndex = rightIndex;

                if(temporaryPalindrome.Length > longestPalindrome.Length) longestPalindrome = temporaryPalindrome;
            }

            return longestPalindrome;
        }
    }
}
