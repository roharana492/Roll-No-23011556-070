using System;

namespace ConsoleLogin_Roha070
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Login App - Roha 070";
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine("=====================================");
            Console.WriteLine("       Welcome to Login System       ");
            Console.WriteLine("=====================================");

            Console.Write("\nEnter Username: ");
            string username = Console.ReadLine();

            Console.Write("Enter Password: ");
            string password = ReadPassword();

            if (username == "admin" && password == "1234")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nLogin successful! Welcome, " + username + " 🎉");

                // 🔥 create HomePage object and show it
                HomePage home = new HomePage(username);
                home.Show();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nInvalid username or password ❌");
            }

            Console.ResetColor();
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }

        // hides password input
        static string ReadPassword()
        {
            string pass = "";
            ConsoleKey key;
            do
            {
                var keyInfo = Console.ReadKey(true);
                key = keyInfo.Key;

                if (key == ConsoleKey.Backspace && pass.Length > 0)
                {
                    pass = pass.Substring(0, pass.Length - 1);
                    Console.Write("\b \b");
                }
                else if (!char.IsControl(keyInfo.KeyChar))
                {
                    pass += keyInfo.KeyChar;
                    Console.Write("*");
                }
            } while (key != ConsoleKey.Enter);

            Console.WriteLine();
            return pass;
        }
    }
}