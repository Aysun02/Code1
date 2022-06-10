using System;

namespace ConsoleApp26
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine(ObjectMethod(23.89));
        }
        public static  object  ObjectMethod(object obj)
        {
            return obj;
        }

    }
}