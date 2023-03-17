using System;

namespace Module9.Task2
{
    internal class Program
    {
        static string[] lastNames =
        {
            "Иванов",
            "Петров",
            "Сидоров",
            "Авдеев",
            "Гайдачук",
        };

        delegate void Sorter(string[] stringArray);
        static event Sorter SortEvent;

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("До сортировки:");
            DisplayStrings();

            string sorterCode = null;
            while (sorterCode == null) 
            {
                Console.Write("Выберите тип сортировки [1 - ASC or 2 - DESC]: ");
                sorterCode = Console.ReadLine();
                try
                {
                    SortEvent = GetSorter(sorterCode);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    sorterCode = null;
                }
                finally
                {
                    Console.WriteLine("============================");
                    DisplayStrings();
                }
            }
        }

        private static void DisplayStrings()
        {
            SortEvent?.Invoke(lastNames);
            foreach (string s in lastNames)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine();
        }

        private static Sorter GetSorter(string sorterCode)
        {
            switch (sorterCode) 
            {
                case "1": return AscendingSorter;
                case "2": return DescendingSorter;
                default: throw new InvalidSorterCodeException(sorterCode);
            }
        }

        static void AscendingSorter(string[] stringArray)
        {
            Array.Sort(stringArray);
        }

        static void DescendingSorter(string[] stringArray)
        {
            Array.Sort(stringArray, (x, y) => string.Compare(y, x));
        }
    }
}
