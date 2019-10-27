using System;
using BasicPractice.IntroPractice;
using Math = BasicPractice.IntroPractice.Math;

namespace BasicPractice
{
    public class Program
    {
        public Program(){}
        
        static void Main(string[] args)
        {
            Console.WriteLine("  ------------------\n <--- Main Class ---> \n  ------------------ \n");
            new Variables();
            new Converter();
            new UserInput();
            new Math();
            new StringClass();
            new ArrayClass();
            new ArrayLinq();
            MethodClass m = new MethodClass();
            Console.WriteLine("Calling Class's Method : " +m.num(5));
        }
    }
}