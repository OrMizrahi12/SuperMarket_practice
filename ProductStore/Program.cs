using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductStore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ShowStartMsg();
            string personName = NameValidation();
            StartProcecMsg(personName);
            Product[] products = new Product[ProductCount()];
            SetProducts(products);
            ShowProductList(products);
        }
        static void ShowStartMsg()
        {
            Console.WriteLine("hey! lats add a few product to your store...\n before it, what is you name?");
        }
        static string NameValidation()
        {
            Console.WriteLine("the name please");
            string name;
            while (true)
            {
                name = Console.ReadLine();
                if (name == null || name.Length <= 0)
                    Console.WriteLine("name not valid");              
                else
                    break;
            }
            return name;
        }
        static void StartProcecMsg(string personName)
        {
            Console.WriteLine($"hey {personName}! how much product you want to fill?");
        }
        static int ProductCount()
        {
            int productCount;
            string productCountInput;
            while (true)
            {
               productCountInput = Console.ReadLine();
                if (int.TryParse(productCountInput, out productCount) && productCount > 0) 
                    return productCount;
                else 
                    Console.WriteLine("only number"); 
            }
        }
        static void SetProducts(Product []products)
        {
            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine($"product {i + 1}:");
                products[i] = new Product(NameValidation(), ProductPriceValidation(), ProductAddDaysValidation());
            }
        }
        static public double ProductPriceValidation()
        {
            Console.WriteLine("the price please");
            double productPrice;
            string productPriceInput;
            while (true)
            {
                productPriceInput = Console.ReadLine();
                if (double.TryParse(productPriceInput, out productPrice) && productPrice > 0)
                    return productPrice;
                else
                    Console.WriteLine("only numbers");
            }
        }
        static public int ProductAddDaysValidation()
        {
            Console.WriteLine("days experetion from now please");
            int productPrice;
            string productPriceInput;
            while (true)
            {
                productPriceInput = Console.ReadLine();
                if (int.TryParse(productPriceInput, out productPrice) && productPrice > 0)
                    return productPrice;
                else
                    Console.WriteLine("only number");
            }
        }
        static public void ShowProductList(Product[] products)
        {
            Console.Clear();
            for (int i = 0; i < products.Length; i++)           
                Console.WriteLine($"{products[i]}\n");         
        }
    
    }
}
