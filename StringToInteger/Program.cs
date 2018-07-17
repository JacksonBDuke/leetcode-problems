/*
    Author: Jackson Duke

    Problem     - https://leetcode.com/problems/string-to-integer-atoi/
    Submission  - https://leetcode.com/submissions/detail/159148654/
    Details
        Status: Accepted
        Submitted: June, 2018
        1079/1079 test cases passed
        Runtime: 88ms
        Notes: "Your runtime beats 97.89 % of csharp submissions"
        
*/

using System;

namespace StringToInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] testcases = new string[]{
                "1",
                "0",
                "",
                "-",
                "\n",
                "           9999999999999999999asdf",
                "   -999999999999999999999999asdf"
            };
            foreach(string s in testcases){
                Console.WriteLine(MyAtoi(s));
            }
        }

        public static int MyAtoi(string str) {
            
            str = str.Trim();
            if(str.Length < 1) return 0;
            int ret = 0;
            int negator = 1;

            if(str[0] == '-'){
                negator = -1;
                str = str.Substring(1);
            }
            else if(str[0] == '+'){
                negator = 1;
                str = str.Substring(1);
            }

            if(str.Length >= 1){
                foreach(char c in str){
                    int charInt = CharToInt(c);
                    if(IsValid(charInt)){
                        checked{
                            try{
                                ret = 10 * ret + charInt;
                            }
                            catch(OverflowException){
                                return negator > 0 ? int.MaxValue : int.MinValue;
                            }
                        }
                    }
                    else break;
                }
            }
            
            return negator * ret;
        }

        public static int CharToInt(char c){
            return (int) c - 48;
        }

        public static bool IsValid(int i){
            return (i < 10 && i > -1);
        }
    }
}
