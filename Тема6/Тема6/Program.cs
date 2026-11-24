using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        Console.WriteLine("ПЛАНИРОВЩИК СОБЫТИЙ");
        Console.WriteLine();

        Console.WriteLine("1. Parse():");

        DateTime date1 = DateTime.Parse("24.11.2026");
        Console.WriteLine("Дата: " + date1.ToShortDateString());

        Console.WriteLine("\n2. ParseExact():");

        DateTime date2 = DateTime.ParseExact(
            "25-12-2026",
            "dd-MM-yyyy",
            CultureInfo.InvariantCulture);

        Console.WriteLine("Дата события: " + date2.ToString("dd.MM.yyyy"));

        Console.WriteLine("\n3. TryParse():");

        Console.Write("Введите дату (дд.мм.гггг): ");
        string input = Console.ReadLine();

        if (DateTime.TryParse(input, out DateTime date3))
        {
            Console.WriteLine("Дата принята: " + date3.ToShortDateString());
        }
        else
        {
            Console.WriteLine("Ошибка: неправильная дата!");
        }

        Console.WriteLine("\n4. TryParseExact():");

        Console.Write("Введите дату в формате гггг/мм/дд: ");
        string input2 = Console.ReadLine();

        if (DateTime.TryParseExact(
            input2,
            "yyyy/MM/dd",
            CultureInfo.InvariantCulture,
            DateTimeStyles.None,
            out DateTime date4))
        {
            Console.WriteLine("Дата принята: " + date4.ToString("dd.MM.yyyy"));
        }
        else
        {
            Console.WriteLine("Ошибка: формат должен быть гггг/мм/дд!");
        }

        Console.WriteLine("\nПланирование завершено.");
    }
}