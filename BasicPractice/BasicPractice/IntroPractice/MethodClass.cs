using System;

namespace BasicPractice.IntroPractice
{
    public class MethodClass
    {
        public MethodClass()
        {
            Console.WriteLine("<---------- Method Class ---------->");
            MyMethod("Evon");
        }

        private static void MyMethod(string name)
        {
            Console.WriteLine("\tHi " +name+ ", The Time is : " +DateTime.Now.ToString("HH:mm:ss, dddd, dd MMMM yyyy"));
        }
    }
}