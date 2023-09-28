using System;

namespace Calculator
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("Choose an operation:");
                Console.WriteLine("1. Addition (+)");
                Console.WriteLine("2. Subtraction (-)");
                Console.WriteLine("3. Multiplication (*)");
                Console.WriteLine("4. Division (/)");
                Console.WriteLine("5. Modulo (%)");
                Console.WriteLine("6. Exit");

                Console.Write("Enter your choice (1-6): ");
                string choice = Console.ReadLine();

                if (choice == "6")
                {
                    Console.WriteLine("Exiting the program.");
                    break; // Exit the loop and the program
                }

                if (choice != "1" && choice != "2" && choice != "3" && choice != "4" && choice != "5")
                {
                    Console.WriteLine("Invalid choice. Please choose a valid operation.");
                    continue; // Go back to the beginning of the loop
                }

                Console.Write("Enter the first number: ");
                double num1;
                if (!double.TryParse(Console.ReadLine(), out num1))
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    continue; // Go back to the beginning of the loop
                }

                Console.Write("Enter the second number: ");
                double num2;
                if (!double.TryParse(Console.ReadLine(), out num2))
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    continue; // Go back to the beginning of the loop
                }

                double result = 0;

                switch (choice)
                {
                    case "1":
                        result = num1 + num2;
                        break;
                    case "2":
                        result = num1 - num2;
                        break;
                    case "3":
                        result = num1 * num2;
                        break;
                    case "4":
                        if (num2 == 0)
                        {
                            Console.WriteLine("Division by zero is not allowed.");
                            continue; // Go back to the beginning of the loop
                        }
                        result = num1 / num2;
                        break;
                    case "5":
                        if (num2 == 0)
                        {
                            Console.WriteLine("Modulo by zero is not allowed.");
                            continue; // Go back to the beginning of the loop
                        }
                        result = num1 % num2;
                        break;
                }

                Console.WriteLine("Result: " + result);
            }
        }
    }

}
