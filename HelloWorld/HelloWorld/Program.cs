namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // var number = 2;
            // var count = 10;
            // var totalPrice = 20.95f;
            // var character = 'A';
            // var firstName = "Mosh";
            // var isWorking = false;
            
            // Console.WriteLine(number);
            // Console.WriteLine(count);
            // Console.WriteLine(totalPrice);
            // Console.WriteLine(character);
            // Console.WriteLine(firstName);
            // Console.WriteLine(isWorking);
            //
            // Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);
            // Console.WriteLine("{0} {1}", float.MinValue, float.MaxValue);

            // const float Pi = 3.14f;
            // Console.WriteLine(Pi);

            // byte b = 1;
            // int i = b;
            // Console.WriteLine(i);

            // int i = 1000;
            // byte b = (byte) i;
            // Console.WriteLine(b);

            // string number = "1234";
            // int i = Convert.ToInt16(number);
            // Console.WriteLine(i);
            
            // try
            // {
            //     string number = "1234";
            //     byte b = Convert.ToByte(number);
            //     Console.WriteLine(b);
            // }
            // catch (Exception e)
            // {
            //     Console.WriteLine("The number couldn't be converted into byte", e);
            // }

            try
            {
                string str = "true";
                bool b = Convert.ToBoolean(str);
                Console.WriteLine(b);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}