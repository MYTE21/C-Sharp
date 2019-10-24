using System;

namespace BasicPractice.IntroPractice
{
    public class Converter
    {
        public Converter()
        {
            Console.WriteLine("<---------- Converter ---------->");
            TypeConvert();
            InverseConverter();
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

        private static void InverseConverter()
        {
            
        }
    }
}