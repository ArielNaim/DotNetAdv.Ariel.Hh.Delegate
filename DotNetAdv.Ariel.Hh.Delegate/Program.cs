using System;

namespace DotNetAdv.Ariel.Hh.Delegate
{
    class Program
    {
        public static void Print()
        {
            Console.WriteLine("Shalom");
        }
        public static void Print2()
        {
            Console.WriteLine("Anouther Function called With same delegate");
        }
        public static void Shalom(string name)
        {
            Console.WriteLine("shalom " + name);
        }
        public static void Welcome(string name)
        {
            Console.WriteLine("Welcome " + name);
        }

        static MyFirstDelegate firstDelegate = Print;
        static MyFirstDelegate secoudDelegate = Print2;
        static Greet greet = Shalom;
        static Greet welcome = Welcome;
        // Greet print2 = new Greet(Print2);// canot work dont get any varibals in Print 2 
        static void Main(string[] args)
        {
            firstDelegate();
            secoudDelegate();
            greet("Ariel");
            welcome("Noa");

        }
    }
}
