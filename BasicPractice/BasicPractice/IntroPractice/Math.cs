using System;

namespace BasicPractice.IntroPractice
{
    public class Math
    {
        public Math()
        {
            Console.WriteLine("<---------- Math ---------->");
            Calculate();
        }

        private static void Calculate()
        {
            double num1 = 10.77;
            double num2 = 5.12;
            
            Console.WriteLine("Max of " +num1+ " and " +num2+ " is : " +System.Math.Max(num1, num2));
            Console.WriteLine("Min of " +num1+ " and " +num2+ " is : " +System.Math.Min(num1, num2));
            Console.WriteLine("Sqrt of " +num1+" is : " +System.Math.Sqrt(num1));
            Console.WriteLine("Abs of " +num1+" is : " +System.Math.Abs(num1));
            Console.WriteLine("Round of " +num1+" is : " +System.Math.Round(num1));
        }
    }
}