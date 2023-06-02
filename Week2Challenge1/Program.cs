using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Challenge1
{
    class Program
    {
        class Products
        {
            public int Id;
            public string Name;
            public int Price;
            public string Category;
            public string BrandName;
            public string Country;
        }
        static char Menu()
        {
            Console.Clear();
            char choice;
            Console.WriteLine("Press 1 to ADD A PRODUCT:");
            Console.WriteLine("Press 2 to View PRODUCTS:");
            Console.WriteLine("Press 3 to VIEW TOTAL STORE WORTH:");
            Console.WriteLine("Press 4 to Exit:");
            choice = char.Parse(Console.ReadLine());
            return choice;
        }
        static Products AddProduct()
        {
            Products s1 = new Products();
            Console.WriteLine("Enter Product ID: ");
            s1.Id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Product Name: ");
            s1.Name = Console.ReadLine();
            Console.WriteLine("Enter Product Price: ");
            s1.Price = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Category(Custom || Non-Custom): ");
            s1.Category = Console.ReadLine();
            Console.WriteLine("Enter BrandName: ");
            s1.BrandName = Console.ReadLine();
            Console.WriteLine("Enter Country: ");
            s1.Country = Console.ReadLine();
            return s1;
        }
        static void viewProduct(Products[] s, int count)
        {
            Console.Clear();
            Console.WriteLine("ID\t\tNAME\t\tPRICE\t\tCATEGORY\t\tBRAND NAME\t\tCOUNTRY");
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(s[i].Id + "\t\t" + s[i].Name + "\t\t" + s[i].Price + "\t\t" + s[i].Category + "\t\t" + s[i].BrandName + "\t\t" + s[i].Country);
            }
            Console.WriteLine("Press Any Key To Continue...");
            Console.ReadKey();
        }
        static void CalculatePrice(Products[] s, int count)
        {
            Console.Clear();
            int total = 0;
            if (count == 0)
            {
                Console.WriteLine("Please Enter a Record First");
            }
            if(count == 1)
            {
                Console.WriteLine(s[0].Price);
            }
            if(count == 2)
            {
                for(int i = 0;i < count;i++)
                {
                    total = total + s[i].Price;
                }
                Console.WriteLine(total);
            }
            if (count > 2)
            {
                for (int i = 0; i < count; i++)
                {
                    total = total + s[i].Price;
                }
                Console.WriteLine(total);
            }
            Console.WriteLine("Press Any Key To Continue...");
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            Products[] s = new Products[10];
            char option;
            int count = 0;
            do
            {
                option = Menu();
                if (option == '1')
                {
                    s[count] = AddProduct();
                    count = count + 1;
                }
                else if (option == '2')
                {
                    viewProduct(s, count);
                }
                else if (option == '3')
                {
                    CalculatePrice(s, count);
                }
                else if (option == '4')
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Choice");
                }

            }
            while (option != '4');
            Console.WriteLine("Press Enter To Exit...");
            Console.Read();
        }
    }
}
