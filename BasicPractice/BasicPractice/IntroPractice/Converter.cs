using System;

namespace BasicPractice.IntroPractice
{
    public class Converter
    {
        public Converter()
        {
            Console.WriteLine("<---------- Converter ---------->");
            TypeConvert();
            UsingConverter();
        }

        private static void TypeConvert()
        {
            Console.WriteLine("Inside TypeConvert : ");
            char ch = '2';
            Console.WriteLine("\t" +ch.GetType());
            int num = ch;
            Console.WriteLine("\t" +num.GetType());
            long lnum = num;
            Console.WriteLine("\t" +lnum.GetType());
            float flnum = lnum;
            Console.WriteLine("\t" +flnum.GetType());
            double dnum = flnum;
            Console.WriteLine("\t" +dnum.GetType());
        }

        private static void UsingConverter()
        {
            int demo = 12;
            double double_demo = Convert.ToDouble(demo);
            char char_demo = Convert.ToChar(demo);
            string string_demo = Convert.ToString(demo);
            bool bool_demo = Convert.ToBoolean(demo);
            
            Console.WriteLine("Inside UsingConverter : ");
            Console.WriteLine("\t" +demo.GetType());
            Console.WriteLine("\t" +double_demo.GetType());
            Console.WriteLine("\t" +char_demo.GetType());
            Console.WriteLine("\t" +string_demo.GetType());
            Console.WriteLine("\t" +bool_demo.GetType());
        }
    }
}