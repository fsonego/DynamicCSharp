using System;

namespace Demo1
{
    class Program
    {

        static void Main(string[] args)
        {
            ShowTimeStatic();

            ShowTimeDynamic();

            ShowTimeDynamicRunTimeError();

            Console.WriteLine("\n\nPresiona una tecla para salir.");
            Console.ReadKey();
        }

        private static void ShowTimeStatic()
        {
            DateTime dt = DateTime.Now;

            string time = dt.ToLongTimeString();

            Console.WriteLine(time);
        }

        private static void ShowTimeDynamic()
        {
            dynamic dt = DateTime.Now;

            string time = dt.ToLongTimeString();

            Console.WriteLine(time);
        }

        private static void ShowTimeDynamicRunTimeError()
        {
            dynamic dt = DateTime.Now;

            string time = dt.IsMorningTime();

            Console.WriteLine(time);
        }

    }
}

