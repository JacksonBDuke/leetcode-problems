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
            Console.WriteLine(GivenSolution(testCase));
            Console.WriteLine(GivenSolution(testCase2));
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
        public static string GivenSolution(string s){
            int start = 0, end = 0;
            for(int i = 0; i < s.Length; i++){
                int len1 = expandAroundCenter(s, i, i);
                int len2 = expandAroundCenter(s, i, i + 1);
                int len = Math.Max(len1, len2);
                if(len > end - start){
                    start = i - (len - 1)/2;
                    end = i + len/2;
                }
            }
            return s.Substring(start, end + 1);
        }

        private static int expandAroundCenter(string s, int left, int right){
            int L = left, R = right;
            while(L >= 0 && R < s.Length && s[L] == s[R]){
                L--;
                R++;
            }
            return R - L - 1;
        }
    }
}
