using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;

namespace ProductStore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ShowStartMsg();
            string PersonName = NameValidation();
            StartProcecMsg(PersonName);
            Product[] products = new Product[SetProductCount()];
            SetProducts(products);
            ShowProductList(products);
            ChooseProduct(products, PersonName);
        }
        // Fulfill function
        static int SetProductCount()
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
        static void SetProducts(Product[] products)
        {
            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine($"product {i + 1}:");
                products[i] = new Product(NameValidation(), ProductPriceValidation(), ProductAddDaysValidation());
            }
        }
        // Validation function
        static string NameValidation()
        {
            string name;

            ShowFieldDescription("the name");
            while (true)
            {
                name = Console.ReadLine();
                if (name == null || name.Length <= 0)
                    ShowErorrValidarionMsg("name not valid");
                else
                    break;
            }
            return name;
        }
        static public double ProductPriceValidation()
        {
            double productPrice; string productPriceInput;

            ShowFieldDescription("the price");
            while (true)
            {
                productPriceInput = Console.ReadLine();
                if (double.TryParse(productPriceInput, out productPrice) && productPrice > 0)
                    return productPrice;
                else
                    ShowErorrValidarionMsg("only numbers");
            }
        }
        static public int ProductAddDaysValidation()
        {
            int productPrice; string productPriceInput;

            ShowFieldDescription("the days experetion from now");
            while (true)
            {
                productPriceInput = Console.ReadLine();
                if (int.TryParse(productPriceInput, out productPrice) && productPrice > 0)
                    return productPrice;
                else
                    ShowErorrValidarionMsg("only numbers");
            }
        }
        static int ChoosingProductValidation(int productsLengthArr)
        {
            int productNumber; string productNumberInput;

            while (true)
            {
                productNumberInput = Console.ReadLine();
                if (int.TryParse(productNumberInput, out productNumber) && (productNumber <= productsLengthArr && productNumber >= 1))
                    return productNumber;
                else
                    ShowErorrValidarionMsg($"only numbers betweem 1 - {productsLengthArr}");
            }
        }
        // UI function 
        static public void ShowProductList(Product[] products)
        {
            Console.Clear();
            for (int i = 0; i < products.Length; i++)
                Console.WriteLine($"#{i + 1}{products[i]}");
        }
        static void ChooseProduct(Product[] products, string costumerName)
        {
            Console.WriteLine("place select product number:");
            int productNumberResult = ChoosingProductValidation(products.Length);
            PrintReception(products, costumerName, productNumberResult);
        }
        static void PrintReception(Product[] products, string costumerName, int productNumberResult)
        {
            Console.Clear();
            Console.WriteLine($"*** Reception *** \n Costumer name: {costumerName} \n {products[productNumberResult-1]}");
        }
        // Text function
        static void ShowStartMsg()
        {
            Console.WriteLine(" hey! lats add a few product to your store...\n before it, what is you name?");
        }
        static void StartProcecMsg(string personName)
        {
            Console.WriteLine($"hey {personName}! how much product you want to fill?");
        }
        static void ShowFieldDescription(string variable) 
        {
            Console.WriteLine($" Enter {variable} plaese");
        }
        static void ShowErorrValidarionMsg(string variable)
        {
            Console.WriteLine(variable);
        }
    }
}
