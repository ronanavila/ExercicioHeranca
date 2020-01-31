using System;
using System.Collections.Generic;
using ExercicioHeranca01.Entities;
using System.Globalization;

namespace ExercicioHeranca01
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();
            Console.Write("Enter the number of products: ");
            int numProducts = int.Parse(Console.ReadLine());

            for(int i =0; i< numProducts; i++)
            {
                Console.WriteLine($"Product # {i} data:");
                Console.Write("Commun, Used or imported (c, u, i): ");
                char ch = char.Parse(Console.ReadLine());
                                
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (ch == 'c')
                {
                    list.Add(new Product(name, price));
                }
                else if(ch == 'i')
                {
                    Console.Write("Custom Fee: ");
                    double customFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new ImportedProduct(name, price,customFee));
                }
                else
                {
                    Console.Write("Manufactured Date (DD/MM/YYYY): ");
                    DateTime date = DateTime.Parse(Console.ReadLine());
                    list.Add(new UsedProduct(name, price, date));

                }
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("---------------");
            foreach (Product ls in list)
            {
                Console.WriteLine(ls.PriceTag());
            }
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
