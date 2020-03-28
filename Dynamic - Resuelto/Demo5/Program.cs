using System;
using System.Reflection;
using System.Text;

namespace Demo5
{
    class Program
    {
        static void Main(string[] args)
        {
            InvokeMethodUsingReflection();
            InvokeMethodUsingDynamic();

            Console.WriteLine("\n\nPresiona una tecla para salir.");
            Console.ReadKey();
        }

        private static void InvokeMethodUsingReflection()
        {
            StringBuilder sb = new StringBuilder();

            sb.GetType()
                .InvokeMember("AppendLine", /// metodo
                    BindingFlags.InvokeMethod, // que vamos hacer
                    null, 
                    sb, // el objeto que vamos a utilizar
                    new object[] { "Hola desde reflection!" }); //Lo que vamos a ejecutar

            Console.WriteLine(sb);
        }


        private static void InvokeMethodUsingDynamic()
        {
            StringBuilder sb = new StringBuilder();

            ((dynamic)sb).AppendLine("Hola desde dynamic!");

            Console.WriteLine(sb);
        }
    }
}

