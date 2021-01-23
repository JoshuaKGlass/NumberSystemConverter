using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace NumberSysConverter
{
    class Program
    {
        //main func 
        static void Main(string[] args)
        {

            //
            // Call recursive method with two parameters.
            //
            //int x = 0;
            string s = "";
            // string total = recursionMeth(156, 10, ref s);
            // //
            // // Write the result from the method calls and also the call count.
            // //
            // s = ReverseResize(total);
            // Console.WriteLine(s);

            //Console.WriteLine(hexCheck(s));

            Console.WriteLine(recursionMeth2(66, 8, ref s));


        }

        static string ReverseResize(string str)
        {
            char[] chars = str.ToCharArray();
            Array.Resize(ref chars, chars.Length - 1);
            Array.Reverse(chars);
            return new string(chars);
        }

        static string hexCheck(string str)
        {
            for (int i = 0; i <= 5; i++)
            {
                switch (i)
                {
                    case 1:
                        str = str.Replace("01", "A");
                        break;
                    case 2:
                        str = str.Replace("11", "B");
                        break;
                    case 3:
                        str = str.Replace("21", "C");
                        break;
                    case 4:
                        str = str.Replace("31", "D");
                        break;
                    case 5:
                        str = str.Replace("41", "E");
                        break;
                    case 6:
                        str = str.Replace("51", "F");
                        break;
                    default:
                        break;
                }
            }


            return str;
        }

        //converts int to bin/oct/hex
        static string recursionMeth(int a, int b, ref string s)
        {

            int rem = a % b; //get remainder 

            s += rem + " "; //append to string
            int div = a / b; //divide to reduce size

            a = div; //a now = the slashed int

            if (a <= 0)
            {
                return s;
            }

            return recursionMeth(a, b, ref s);
        }

        static string recursionMeth2(int a, int b, ref string s)
        {
            string x = a.ToString();
            int Length = x.Length;

            int calc=0;

            //eg 66 base 8, 6*8^1 + 6*8^0 = 54
            //eg 5e base 16, 5*16 + e(14)*16^0 = 94

             for(int i = Length; i == 0; i--){
                calc = a*b^i;
                s+=calc;
             }

            return s;



        }

        static string reJoin(string s)
        {
            s.Replace(" ", string.Empty);
            return s;
        }
    }
}
