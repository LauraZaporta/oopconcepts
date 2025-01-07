using System;
using System.Reflection.Metadata.Ecma335;

namespace oopconcepts
{
    public class HelperClass
    {
        public static int Absolute(int num)
        {
            int result = (num < 0) ? num * -1 : num;
            return result;
        }
        public static void HelloWorld() { Console.WriteLine("Hello World!"); }
    }
}
