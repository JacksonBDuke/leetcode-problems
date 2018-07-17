using System;

namespace ZigZagConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            string testString1 = "PAYPALISHIRING";
            string solutionCase1 = "PINALSIGYAHRPI";

            ZigZagString testCase1 = new ZigZagString(testString1, 4);
            testCase1.Print();
        }
        
        public class ZigZagString{

            private string convertedString;
            public string ConvertedString{
                get{return convertedString;}
            }

            private int numRows;
            public int NumRows{
                get{return numRows;}
            }

            public ZigZagString(string s, int n){
                convertedString = Convert(s, n);
                numRows = n;
            }
            
            private string Convert(string s, int numRows){
                return "test";
            }

            public void Print(){
                int spacer = this.NumRows - 2 >= 0 ? this.NumRows - 2: 0;
                int numCharsToPrint = 1;
                int numSpacesToPrint = spacer;
                int columns = calculateColumns(spacer);
                
                string [,] zigZagArray = new string[this.NumRows, columns];

                

                int calculateColumns(int maxInSpaces){
                    int rowsAndSpaces = this.numRows + maxInSpaces;
                    int numFullyPopulatedColumsAndSpacers = this.ConvertedString.Length / rowsAndSpaces;
                    int numCharactersLeft = this.ConvertedString.Length % rowsAndSpaces;

                    return numCharactersLeft > 0 ? numFullyPopulatedColumsAndSpacers + 1 : numFullyPopulatedColumsAndSpacers;
                }
            }
        }
    }
}
