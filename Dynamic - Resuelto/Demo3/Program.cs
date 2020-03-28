using System;

namespace Demo3
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 42;
            Show(i); // --> PrintMe(int value) static binding
            
            dynamic d;
            //WriteLine("Crear [i]nt o [d]ouble");
            //ConsoleKeyInfo choice = ReadKey(intercept: true);
            //if (choice.Key == ConsoleKey.I)
            //{
            //    d = 99;
            //}
            //else
            //{
            //    d = 55.5;
            //}
            //Show(d);
            
            d = long.MaxValue;
            Show(d);

            d = "Hello";
            Show(d);


            Console.WriteLine("\n\nPresiona una tecla para salir.");
            Console.ReadKey();
        }

        static void Show(int value)
        {
            Console.WriteLine($"Show(int) valor invocado {value}");
        }

        static void Show(long value)
        {
            Console.WriteLine($"Show(long) valor invocado: {value}");
        }

        static void Show(dynamic value)
        {
            Console.WriteLine($"Show(dynamic) invoco a {value.GetType()} valor: {value}");
        }

        //static void Show(object value)
        //{
        //    Console.WriteLine($"PrintMe(object value) = {value}");
        //}

    }
}

