using System;

namespace InventoryStorage
{
    internal class Program
    {
        static string[,] products = new string[100, 3];

        static int count = 0;

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the inventory storage");

            Console.WriteLine("==================================");
            Console.WriteLine("==================================");


            while (true)
            {
                Console.WriteLine("1. Add product");
                Console.WriteLine("2. Update product title");
                Console.WriteLine("3. Update product quantity");
                Console.WriteLine("4. Update product price");
                Console.WriteLine("5. View product");
                Console.WriteLine("6. Exit product");

                string UserInput = Console.ReadLine();

                int choice = Convert.ToInt32(UserInput);

                switch (choice)
                {
                    case 1:
                        // add product
                        AddProduct();
                        break;
                    case 2:
                        // update product title
                        UpdateProductTitle();
                        break;
                    case 3:
                        // update product quantity
                        UpdateProductQuantity();
                        break;
                    case 4:
                        // update product price
                        UpdateProductPrice();
                        break;
                    case 5:
                        // view product price
                        ViewProducts();
                        break;
                    case 6:
                        // exit program
                        Environment.Exit(0);
                        break;
                }
            }
        }
        private static void AddProduct()
        {
            Console.WriteLine("Please enter product title:");
            string ProductTitle = Console.ReadLine();

            Console.WriteLine("Please enter product quantity:");
            string ProductQuantity = Console.ReadLine();

            Console.WriteLine("Please enter product price:");
            string ProductPrice = Console.ReadLine();

            products[count, 0] = ProductTitle;
            products[count, 1] = ProductQuantity;
            products[count, 2] = ProductPrice;

            count++;

            Console.WriteLine("Product added successfully:");
        }

        private static void UpdateProductTitle()
        {
            Console.WriteLine("Enter product name to update:");
            string ProductName = Console.ReadLine();
            int index = -1;
            if (count > 0)
            {
                for (int i = 0; i < count; i++)
                {
                    if (products[i, 0] == ProductName)
                    {
                        index = i;
                        break;
                    }
                }
                if (index != -1)
                {
                    Console.WriteLine("Enter new product title:");
                    string NewTitle = Console.ReadLine();
                    products[index, 0] = NewTitle;
                    Console.WriteLine("Product title updated successfully!");
                }
            }
            else
            {
                Console.WriteLine("Product not found");
            }
        }

        private static void UpdateProductQuantity()
        {
            Console.WriteLine("Enter product name to update:");
            string ProductName = Console.ReadLine();
            int index = -1;
            if (count > 0)
            {
                for (int i = 0; i < count; i++)
                {
                    if (products[i, 0] == ProductName)
                    {
                        index = i;
                        break;
                    }
                }
                if (index != -1)
                {
                    Console.WriteLine("Enter product new quantity:");
                    string NewQuantity = Console.ReadLine();
                    products[index, 1] = NewQuantity;
                    Console.WriteLine("Quantity updated successfully");
                }
            }
            else
            {
                Console.WriteLine("Product not found!");
            }
        }
        private static void UpdateProductPrice()
        {
            Console.WriteLine("Enter product name to update:");
            string ProductTitle = Console.ReadLine();
            int index = -1;
            if (count > 0)
            {
                for (int i = 0; i < count; i++)
                {
                    if (products[i, 0] == ProductTitle)
                    {
                        index = i;
                        break;
                    }
                }
                if (index != -1)
                {
                    Console.WriteLine("Enter new product price:");
                    string NewPrice = Console.ReadLine();
                    products[index, 2] = NewPrice;
                    Console.WriteLine("Product price updated successfully");
                }
            }
            else
            {
                Console.WriteLine("Product not found!");
            }
        }
        private static void ViewProducts()
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"product id: {i + 1}, product price: {products[i, 0]}, product quantity: {products[i, 1]}, product price: {products[i, 2]}");
            }
        }
    }
}