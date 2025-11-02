using System;

namespace ConsoleCalculatorClasses_Roha070
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Calculator with Classes - Roha 070";
            History history = new History();
            Calculator calc = new Calculator(history);

            int choice;
            do
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\n============================");
                Console.WriteLine("     CALCULATOR PROGRAM     ");
                Console.WriteLine("============================");
                Console.ResetColor();

                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtraction");
                Console.WriteLine("3. Multiplication");
                Console.WriteLine("4. Division");
                Console.WriteLine("5. View History");
                Console.WriteLine("6. Clear History");
                Console.WriteLine("7. Exit");

                Console.Write("\nEnter your choice (1-7): ");
                int.TryParse(Console.ReadLine(), out choice);

                switch (choice)
                {
                    case 1: calc.PerformOperation('+'); break;
                    case 2: calc.PerformOperation('-'); break;
                    case 3: calc.PerformOperation('*'); break;
                    case 4: calc.PerformOperation('/'); break;
                    case 5: history.Show(); break;
                    case 6: history.Clear(); break;
                    case 7: Console.WriteLine("Exiting..."); break;
                    default: Console.WriteLine("Invalid choice!"); break;
                }

            } while (choice != 7);

            Console.WriteLine("\nPress any key to close...");
            Console.ReadKey();
        }
    }
}
