using System;

namespace Demo2
{
    class Program
    {
        static void Main(string[] args)
        {

            int i = 42;
            dynamic di = i;
            int i2 = di;

            Console.WriteLine($"i = {i} di = {di} i2 = {i2}");

            //string s = "hello";
            //dynamic ds = s;
            //int x = ds;

            long l = 99;
            dynamic dl = l;
            int y = (int)dl;

            Console.WriteLine($"l = {l} dl = {dl} y = {y}");


            dynamic z = "Hi there";
            Console.WriteLine($"z is a {z.GetType()} = {z}");

            z = 42;
            Console.WriteLine($"z is a {z.GetType()} = {z}");

            Console.WriteLine("\n\nPresiona una tecla para salir.");
            Console.ReadKey();
        }
    }
}


