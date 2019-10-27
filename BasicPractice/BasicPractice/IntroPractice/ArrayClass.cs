using System;

namespace BasicPractice.IntroPractice
{
    public class ArrayClass
    {
        public ArrayClass()
        {
            Console.WriteLine("<---------- Programming Language ---------->");
            ProgrammingLanguage();
        }

        private static void ProgrammingLanguage()
        {
            string[] programLanguage = { "C", "C++", "Java", "Python", "C#", "JavaScript", "MathLab"};
            
            Console.WriteLine("My Programming Languages : ");
            foreach (string name in programLanguage)
            {
                Console.WriteLine("\t" +name);
            }
            
            Console.WriteLine("My Programming Languages (Sorted List) : ");
            Array.Sort(programLanguage);
            foreach (string name in programLanguage)
            {
                Console.WriteLine("\t" +name);
            }
        }
    }
}