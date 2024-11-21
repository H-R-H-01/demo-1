using System;

namespace demo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task_1
            //Console.WriteLine("Enter your Credit Score");
            //int cScore = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter your Annual Income");
            //int income = int.Parse(Console.ReadLine());

            //Console.WriteLine($"\n\nUser's Credit Score : {cScore} \nUser's Annual Income : {income}\n\n");

            //if (cScore > 700 && income > 50000)
            //{
            //    Console.WriteLine("You are eligible for the Loan.");
            //}
            //else
            //{
            //    Console.WriteLine("Your input doesn't meet the requirements for the loan");
            //}
            #endregion

            #region Task_2
            ////double balance = 10000;
            //Console.WriteLine("Enter the balance");
            //double balance = double.Parse(Console.ReadLine());
            //Console.WriteLine("---- Transaction simulation ----");
            //int choice = 0;
            //do
            //{
            //    Console.WriteLine("\n\nEnter your choice :\n1.Check Balance\n2.Withdraw\n3.Deposit\n4.Exit\n");
            //    choice = int.Parse(Console.ReadLine());
            //    switch (choice)
            //    {
            //        case 1:
            //            Console.WriteLine($"Your current Balance is {balance}");
            //            break;
            //        case 2: 
            //            Console.WriteLine("Enter the amount to withdraw : ");
            //            double withdraw = double.Parse(Console.ReadLine());
            //            if ( (withdraw < balance) && ( (withdraw % 100 == 0) || (withdraw % 500 == 0) ) )
            //            {
            //                balance -= withdraw;
            //                Console.WriteLine($"Withdrawal succesfull. Your current balance is {balance}");
            //            }
            //            else
            //            {
            //                Console.WriteLine($"\n\n**Enter a valid amount in multiples of 100 or 500. Your current balance is {balance}\n\n");
            //            }
            //            break;
            //        case 3:
            //            Console.WriteLine("Enter the amount to deposit : ");
            //            double deposit = double.Parse(Console.ReadLine());
            //            if (deposit > 0)
            //            {
            //                balance += deposit;
            //                Console.WriteLine($"Deposit successful. Your current balance is {balance}");
            //            }
            //            else
            //            {
            //                Console.WriteLine("Enter a valid amount to deposit");
            //            }
            //            break;
            //        case 4:
            //            Console.WriteLine("Thank you for using the Transaction Simulator");
            //            break;
            //        default:
            //            Console.WriteLine("Enter a valid choice");
            //            break;
            //    }
            //} while (choice != 4);
            #endregion

            #region Task_3
            ////Print the balance of multiple users
            //int[] cId = new int[5];
            //double[] cBal = new double[5];
            //double[] interest = new double[5];
            //int[] nYears = new int[5];
            //double[] fBal = new double[5];

            //for (int i = 0; i < 5; i++)
            //{
            //    cId[i] = i + 1;
            //    Console.WriteLine($"\nEnter the customer {i}'s Initial Balance : ");
            //    cBal[i] = double.Parse(Console.ReadLine());
            //    Console.WriteLine($"\nEnter the customer {i}'s Annual Interest Rate : ");
            //    interest[i] = double.Parse(Console.ReadLine());
            //    Console.WriteLine($"\nEnter the customer {i}'s Duration of investment (no. of years) : ");
            //    nYears[i] = int.Parse(Console.ReadLine());
            //}

            //Console.WriteLine("Customer Id\tBalance\t\tFuture Balance");
            //for (int j = 0; j < 5; j++)
            //{
            //    fBal[j] = cBal[j] * Math.Pow((1 + interest[j] / 100), nYears[j]);
            //    Console.WriteLine($"{cId[j]}\t\t{cBal[j]}\t\t{fBal[j]}");
            //}
            #endregion

            #region Task_4
            ////Ask user for Account_No and print their balance
            //int[] cust_id = new int[5] { 1, 2, 3, 4, 5 };
            //int[] accNo = new int[5] { 11111111, 22222222, 33333333, 44444444, 55555555 };
            //double[] accBal = new double[5] { 1000, 2000, 3000, 4000, 5000 };
            //int userInput;
            //bool isValid = false;

            //do
            //{
            //    Console.WriteLine("Enter your Account No:");
            //    if (int.TryParse(Console.ReadLine(), out userInput))
            //    {
            //        int index = Array.FindIndex(accNo, acc => acc == userInput);
            //        if (index != -1)
            //        {
            //            Console.WriteLine($"Your account balance is: {accBal[index]}");
            //            isValid = true;
            //        }
            //        else
            //        {
            //            Console.WriteLine("Invalid Account Number. Try again.");
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("Invalid Account Number. Try again.");
            //    }
            //} while (!isValid);
            #endregion

            #region Task_5
            //Console.Write("Create a password for your bank account: ");
            //string password = Console.ReadLine();

            //if (password.Length < 8)
            //{
            //    Console.WriteLine("Password must be at least 8 characters long");
            //}
            //else if (!password.Any(char.IsUpper))
            //{
            //    Console.WriteLine("Password must contain at least one uppercase letter");
            //}
            //else if (!password.Any(char.IsDigit))
            //{
            //    Console.WriteLine("Password must contain at least one digit");
            //}
            //else
            //{
            //    Console.WriteLine("Password is valid.");
            //}
            #endregion

            #region Task_6
            ////program that maintains a list of bank transactions (deposits and withdrawals) for a customer
            //List<string> transactions = new List<string>();

            //while (true)
            //{
            //    Console.WriteLine("\nEnter an option:\n1. Deposit\n2. Withdraw\n3. View Transactions\n4. Exit");

            //    string choice = Console.ReadLine();

            //    switch (choice)
            //    {
            //        case "1":
            //            Console.Write("Enter deposit amount: ");
            //            decimal depositAmount;
            //            if (decimal.TryParse(Console.ReadLine(), out depositAmount))
            //            {
            //                transactions.Add($"Deposit: ${depositAmount:F2}");
            //                Console.WriteLine("Deposit added successfully!");
            //            }
            //            else
            //            {
            //                Console.WriteLine("Invalid amount. Please try again.");
            //            }
            //            break;

            //        case "2":
            //            Console.Write("Enter withdrawal amount: ");
            //            decimal withdrawalAmount;
            //            if (decimal.TryParse(Console.ReadLine(), out withdrawalAmount))
            //            {
            //                transactions.Add($"Withdrawal: ${withdrawalAmount}");
            //                Console.WriteLine("Withdrawal added successfully!");
            //            }
            //            else
            //            {
            //                Console.WriteLine("Invalid amount. Please try again.");
            //            }
            //            break;

            //        case "3":
            //            Console.WriteLine("\nTransaction History:");
            //            foreach (string transaction in transactions)
            //            {
            //                Console.WriteLine(transaction);
            //            }
            //            break;

            //        case "4":
            //            Console.WriteLine("Thank you for using the simulator");
            //            return;

            //        default:
            //            Console.WriteLine("Invalid choice. Please try again.");
            //            break;
            //    }
            //}
            #endregion

            #region Task_7
            #endregion
        }
    }
}
