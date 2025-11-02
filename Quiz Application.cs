using System;

namespace ConsoleQuiz_Roha070
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Quiz quiz = new Quiz();
            quiz.Start();

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
