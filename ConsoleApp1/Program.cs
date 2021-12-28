using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string MyName = "Pyotr";
            byte MyAge = 38;
            bool HaveYouaPet = false;
            double MyFitSize = 43;

            Console.WriteLine("My name is " + MyName);
            Console.WriteLine("My age is " + MyAge);
            Console.WriteLine("Do you have a pet? " + HaveYouaPet);
            Console.WriteLine("My shoe size is " + MyFitSize);
            Console.WriteLine("\x23");

            Console.ReadKey();
        }
    }
}
