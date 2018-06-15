using System;

namespace Fib
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] testCases = new int[]{
                0, 4, 9, 25
            };
            
            foreach(int i in testCases){
                Console.WriteLine("Fib for " + i + " is " + fib(i));
            }
        }

        public static int fib(int i){

            return recursiveFib(i, 0, 1);
        }

        public static int recursiveFib(int i, int prevValue, int currentValue){
            if(i == 0) return prevValue + currentValue;
            else return recursiveFib(--i, currentValue, prevValue + currentValue);
        }
    }
}
