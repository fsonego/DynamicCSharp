using System;
using System.Reflection;

namespace Demo4
{
    class Program
    {
        class Product
        {
            public object Name { get; set; }
            public dynamic Description { get; set; }
        }
        static void Main(string[] args)
        {

            Product c = new Product();

            //c.Name.DynamicMethod();
            //c.Description.DynamicMethod();


            PropertyInfo nameProperty = typeof(Product).GetProperty("Name");
            foreach (var attribute in nameProperty.CustomAttributes)
            {
                Console.WriteLine(attribute);
            }
            Console.WriteLine($"{nameProperty.PropertyType} Name");

            Console.WriteLine();

            PropertyInfo descriptionProperty = typeof(Product).GetProperty("Description");
            foreach (var attribute in descriptionProperty.CustomAttributes)
            {
                Console.WriteLine(attribute);
            }
            Console.WriteLine($"{descriptionProperty.PropertyType} Description");



            Console.WriteLine("\n\nPresiona una tecla para salir.");
            Console.ReadKey();

           
        }
    }
}


