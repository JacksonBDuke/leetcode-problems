using System;

namespace RepeatedStringMatch
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

        public static int RepeatedMatch(String a, String b){
            string temp = a;
            int index = -1;
            int aIndex = 0;
            for(int i = 0; i < b.Length; ++i){
                if(a[aIndex] == b[i]){
                    ++aIndex;
                    if(aIndex >= a.Length){
                        index = i;
                        break;
                    }
                }
            }

            return -1;
        }
    }
}
