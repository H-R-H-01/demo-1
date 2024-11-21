using System;

namespace demo1
{
    internal class Programs
    {
        static void main(string[] args)
        {
            Console.WriteLine("Enter the price of the item");
            int price = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the No. of items to purchase");
            int quantity = int.Parse(Console.ReadLine());

            double amount = price * quantity;
            double finAmt;
            if (amount > 50000)
            {
                amount = amount - (amount / 10);
                Console.WriteLine($"Amount after discount is {amount}");
            }
            finAmt = amount + (amount * 0.18);

            Console.WriteLine($"The Amount to be paid is {finAmt}(incl. GST)");


            //special discount eligibility check
            Console.WriteLine("Enter the Loyalty Point ");
            int loyaltypoint = int.Parse(Console.ReadLine());
            Console.WriteLine("Total Purchase Amount of the customer : ");
            int totAmt = int.Parse(Console.ReadLine());
            if (loyaltypoint > 100 && totAmt > 1000)
            {
                Console.WriteLine("You are eligible for the Special Discounts.");
            }
            else
            {
                Console.WriteLine("Your input doesn't meet the requirements for the Special Discounts");
            }

            //electronic gadget purchase simulation
            Console.WriteLine("Enter your Choice :\n1.Check Available Stock\n2.Buy Product\n3.Return Product");
            int stock = 15;
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine($"The current stock of the product : {stock}");
                    break;
                case 2:
                    Console.WriteLine($"Enter the no. of products to purchase");
                    int qnt = int.Parse(Console.ReadLine());
                    if (stock > qnt)
                    {
                        Console.WriteLine("Purchased succesfully");
                    }
                    else
                    {
                        Console.WriteLine("Enter a valid quantity, you cannot purchase the whole stock");
                    }
                    break;
                case 3:
                    Console.WriteLine($"Enter the no. of products to return");
                    int ret = int.Parse(Console.ReadLine());
                    stock += ret;
                    Console.WriteLine($"The current stock of the product : {stock}");
                    break;

                default:
                    Console.WriteLine("Enter a valid choice");
                    break;
            }

            //Student Scholarship eligibilty check
            Console.WriteLine("Enter your GPA : ");
            double GPA = int.Parse(Console.ReadLine());
            Console.WriteLine("No. of extracurricular activities participated");
            int eca = int.Parse(Console.ReadLine());
            if (GPA > 3.5 && eca > 2)
            {
                Console.WriteLine("You are eligible for the Scholarship.");
            }
            else
            {
                Console.WriteLine("Your input doesn't meet the requirements for the Scholarship");
            }
        }
    }
}



