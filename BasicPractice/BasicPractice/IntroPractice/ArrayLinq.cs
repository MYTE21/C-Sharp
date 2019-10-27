using System;
using System.Linq;

namespace BasicPractice.IntroPractice
{
    public class ArrayLinq
    {
        public ArrayLinq()
        {
            Console.WriteLine("<---------- Array Linq ---------->");
            howArray();
        }

        private static void howArray()
        {
            int num ;
            int[] numArray = new int[10];
            Random random = new Random();

            for (int i=0;i<numArray.Length;i++)
            {
                num = random.Next(1, 100);
                numArray[i] = num;
            }
            
            Console.WriteLine("The Numbers are : ");
            foreach (int value in numArray)
            {
                Console.Write("\t" +value);
            }
            Console.WriteLine("\nMax : " +numArray.Max());
            Console.WriteLine("Min : " +numArray.Min());
            Console.WriteLine("Sum : " +numArray.Sum());

            try
            {
                Console.WriteLine("100 index of numArray : " +numArray[100]);
            }
            catch (Exception e)
            {
                Console.WriteLine("The Error is : " +e);
            }
            Console.WriteLine("End of Array Linq ...!");
            
        }
    }
}