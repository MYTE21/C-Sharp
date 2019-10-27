using System;

namespace BasicPractice.IntroPractice
{
    public class MethodClass
    {
        public MethodClass()
        {
            Console.WriteLine("<---------- Method Class ---------->");
            MyMethod();
        }

        private static void MyMethod()
        {
            Console.WriteLine("\t The Time is : " +DateTime.Now.ToString("HH:mm:ss, dddd, dd MMMM yyyy"));
        }
    }
}