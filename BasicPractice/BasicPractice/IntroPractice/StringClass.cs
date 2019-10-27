using System;
using System.Linq;

namespace BasicPractice.IntroPractice
{
    public class StringClass
    {
        public StringClass()
        {
            Console.WriteLine("<---------- String Class ---------->");
            Mssg();
        }

        private static void Mssg()
        {
            string firstName = "Md. Abul Hosain ";
            string lastName = "Bablu Korim Mostofa";
            
            Console.WriteLine("First Name : " +firstName+ ", Last Name : " +lastName);
            Console.WriteLine("First Name Length : " +firstName.Length+ ", Last Name Length : " +lastName.Length);
            
            Console.WriteLine("Lower : " +firstName.ToLower()+lastName.ToLower());
            Console.WriteLine("Lower : " +firstName.ToUpper()+lastName.ToUpper());

            string fullName = string.Concat(firstName, lastName);
            Console.WriteLine("Full Name : " +fullName);
            string name = $"The full name is {fullName}";
            Console.WriteLine(name);
            


        }
    }
}