using System;

//Elmey Nicolene Stapelberg
// Software Design & Testing with C# 
//SDT621
//Formative Assessment 1 
// Section A 
//Question 2

namespace SimpleATMSystemSectionAQ2
{
    class Program
    {
        // Strategic Use of Constants
        const string SystemsName = "CTU SIMPLE ATM SYSTEM";
        const double MinimumBalance = 0.00;

        static void Main(string[] args)
        {
            //  Code Organization (Methods)
            DisplayHeader();

            // User Identification with Recommendation 1 (Trim Whitespace)
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("HI WHAT IS YOUR NAME?");
            Console.ResetColor();
            string name = Console.ReadLine()?.Trim(); // Trim whitespace
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"WELCOME {name?.ToUpper()}!");
            Console.ResetColor();

            //  Process logic moved to specialized method
            ProcessWithdrawal();

            // Termination
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }

        //  Method for Header
        static void DisplayHeader()
        {
            Console.ForegroundColor = ConsoleColor.Magenta; // Purple
            Console.WriteLine($"===== {SystemsName} =====");
            Console.ResetColor();
            Console.WriteLine();
        }

        //  Method for logic and balance handling
        static void ProcessWithdrawal()
        {
            // Capture Financial Inputs with Error Handling
            double balance = GetValidNumericInput("Enter account balance: ");
            double withdrawal = GetValidNumericInput("Enter withdrawal amount: ");

            // Transaction Logic
            if (withdrawal > balance)
            {
                // Recommendation 3: Red for error messages
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nWithdrawal failed! Insufficient funds.");
                Console.ResetColor();
            }
            else
            {
                double updatedBalance = balance - withdrawal;
                PrintReceipt(updatedBalance);
            }
        }

        // Method for Output
        static void PrintReceipt(double updatedBalance)
        {
            // Recommendation 3: Blue/Cyan for success output
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\nWithdrawal successful!");

            // Formatting: "F2" ensures 2 decimal places, Replace converts '.' to ',' 
            string formattedBalance = updatedBalance.ToString("F2").Replace('.', ',');
            Console.WriteLine($"Updated Balance: {formattedBalance}");

            // Timestamp Display
            Console.WriteLine($"Transaction Time: {DateTime.Now:dd MMM yyyy HH:mm:ss}");
            Console.ResetColor();
        }

        // Validates user input with Recommendation 1 (Prevent Negative Withdrawals)
        static double GetValidNumericInput(string prompt)
        {
            double result;
            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine();

                // Error Handling: TryParse prevents crashes and >= MinimumBalance prevents negative values
                if (double.TryParse(input, out result) && result >= MinimumBalance)
                {
                    return result;
                }

                // Recommendation 3: Red for validation errors
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Invalid entry. Please enter a valid number (Minimum: {MinimumBalance}).");
                Console.ResetColor();
            }
        }
    }
}