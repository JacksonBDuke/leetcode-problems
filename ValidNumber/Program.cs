/*
    Author: Jackson Duke

    Leetcode Problem - https://leetcode.com/problems/valid-number/description/
    Incomplete
*/

using System;
using System.Text.RegularExpressions;

namespace ValidNumber
{
    class Program
    {
        static string pattern = @"(\+|\-)?\d*\.?\d*";
        static Regex rgx = new Regex(pattern);
        static void Main(string[] args)
        {
            string[] testcases = new string[]{
                "0",
                " 0.1",
                "abc",
                "-",
                "1 a",
                "  2e10",
                "   2e-10"
            };
            // foreach(string s in testcases){
            //     Console.WriteLine(s + ": " + IsNumber(s));
            // }
            string test = "\n";
            Console.WriteLine(test + "\t" + CheckNumber(test));
        }

        public static bool IsNumber(string s){
            string testString = s.Trim();

            

            return false;
        }

        public static bool CheckNumber(string s){
            string testString = s.Trim();
            return rgx.IsMatch(testString);
        }
    }
}
