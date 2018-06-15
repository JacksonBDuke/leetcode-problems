using System;

namespace StringToInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] testcases = new string[]{
                "                    24935wefd",
                "    -35234245-04582sdf",
                "",
                "-",
                "\n"
            };
            foreach(string s in testcases){
                Console.WriteLine("" + MyAtoi(s));
            }
        }

        public static int MyAtoi(string str) {
            
            str = str.Trim();
            if(str.Length < 1) return 0;
            int ret = 0;
            int negator = 1;

            if(str[0] == '-'){
                negator = -1;
            }

            if(str.Length > 1){
                str = str.Substring(1);

                foreach(char c in str){
                    int charInt = CharToInt(c);
                    if(IsValid(charInt)){
                        checked{
                            try{
                                ret = 10 * ret + charInt;
                            }
                            catch(OverflowException){
                                return ret > 0 ? int.MinValue : int.MaxValue;
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
