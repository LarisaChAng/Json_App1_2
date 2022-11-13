using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Json_App1_2;
using System.IO;
using System.Text.Json;



namespace Json_App1_2_contin
{
    class Program
    {
        static void Main(string[] args)
        {
            string jsonString = String.Empty;
            using (StreamReader sr = new StreamReader("../../../Products.json"))
            {
                jsonString = sr.ReadToEnd();
            }
            Product[] products = JsonSerializer.Deserialize<Product[]>(jsonString);

            Product maxProduct = products[0];
            foreach (Product p in products)
            {
                if (p.Price > maxProduct.Price)
                {
                    maxProduct = p;
                }
            }
            Console.WriteLine($"{maxProduct.Name} {maxProduct.Price}");
            Console.WriteLine($"Соответствующий код товара={maxProduct.Code}");
            Console.ReadKey();

        }
    }
}