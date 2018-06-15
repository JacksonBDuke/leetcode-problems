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
