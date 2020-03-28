using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using static System.Console;

namespace Demo5.SQL
{
    class Program
    {
        private const string ConnectionString = @"Data Source=.;Initial Catalog=Dynamic;Integrated Security=True";
        static void Main(string[] args)
        {
            //using (var cn = new System.Data.SqlClient.SqlConnection(ConnectionString))
            //{
            //    cn.Open();

            //    IEnumerable<Product> allProducts = 
            //        cn.Query<Product>("SELECT * FROM Products");

            //    foreach (Product product in allProducts)
            //    {
            //       WriteLine($"{product.ProdcutId} {product.ProductDescription} {product.Price} );
            //    }
            //}

            using (var cn = new SqlConnection(ConnectionString))
            {
                cn.Open();

                IEnumerable<dynamic> allProducts = cn.Query("SELECT * FROM Products");

                foreach (dynamic product in allProducts)
                {
                    Console.WriteLine($"{product.ProductId} {product.ProductDescription} {product.Price}");
                }
            }


            Console.WriteLine("\n\nPresiona una tecla para salir.");
            Console.ReadKey();

        }
    }
}

