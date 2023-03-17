using System;

namespace Module9.Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Exception[] exceptions = {
                new MyException(),
                new ArgumentNullException(),
                new DivideByZeroException(),
                new InvalidOperationException(),
                new ArgumentOutOfRangeException()
            };

            foreach (var exception in exceptions)
            {
                try
                {
                    throw exception;
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Catched exception: {e.GetType().FullName}");
                    Console.WriteLine($"Message: {e.Message}");
                }
                finally
                {
                    Console.WriteLine();
                }
            }
            Console.ReadKey();
        }
    }
}
