using IronPython.Hosting;
using Microsoft.Scripting.Hosting;
using System;

namespace Demo6
{
    class Program
    {
        static void Main(string[] args)
        {
            ScriptEngine engine = Python.CreateEngine();

            string simpleExpression = "2 + 2";

            dynamic dynamicResult = engine.Execute(simpleExpression);
            //int typedResult = engine.Execute<int>(simpleExpression);

            Console.WriteLine($"Resultado de la expresión: {dynamicResult}");


            Console.WriteLine("\n\nPresiona una tecla para salir.");
            Console.ReadKey();

        }
    }
}
