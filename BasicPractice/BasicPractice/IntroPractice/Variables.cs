using  System ;

namespace BasicPractice.IntroPractice
{
    public class Variables
    {
        private static string lastName = "Evon", firstName = "Md. Yasmi Tohabar", fullName = firstName + lastName;
        private static int regNum = 2016831021;
        
        public Variables()
        {
            Print();
        }
        public static void Print()
        {
            Console.WriteLine("My full name is : " +fullName);
            Console.WriteLine("    Reg. No. : " +regNum);
        }
    }
}