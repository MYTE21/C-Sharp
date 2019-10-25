using System;

namespace BasicPractice.IntroPractice
{
    public class UserInput
    {
        public UserInput()
        {
            MainInput();
        }

        private static void MainInput()
        {
            Console.WriteLine("Enter Your Name : ");
            string name = Console.ReadLine();
            Console.WriteLine("What is the time ..? Never mind ... Good-morning " +name);
            Console.WriteLine(name+ ", how old are you ...? : ");
            int age = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Only " +age+ " ...! You're young ...!");
        }
    }
}