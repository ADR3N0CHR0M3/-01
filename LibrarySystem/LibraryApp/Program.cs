using System;
using LibraryLib;

class Program
{
    static void Main()
    {
        LibraryFunctions library = new LibraryFunctions();

        Console.WriteLine("=== СИСТЕМА УПРАВЛЕНИЯ БИБЛИОТЕКОЙ ===");

        Console.WriteLine("Главный библиотекарь: " + library.GetChiefLibrarian());
        Console.WriteLine("Название библиотеки: " + library.GetLibraryName());

        Console.WriteLine("\nСписок сотрудников:");

        foreach (string employee in library.GetStaff())
        {
            Console.WriteLine("- " + employee);
        }

        Console.WriteLine("\nДобавление нового сотрудника:");

        try
        {
            library.AddStaff("Петров Петр Петрович");
            Console.WriteLine("Сотрудник успешно добавлен!");

            library.RemoveStaff("Петров Петр Петрович");
            Console.WriteLine("Сотрудник успешно удален!");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine("Ошибка: " + ex.Message);
        }

        Console.WriteLine("\nГенерация кода книги:");

        string bookCode = library.GenerateBookCode("fantasy", 15);

        Console.WriteLine("Код книги: " + bookCode);
        Console.WriteLine("\nПроверка сотрудника:");

        if (library.FindStaff("Петрова Анна Сергеевна"))
        {
            Console.WriteLine("Сотрудник найден!");
        }
        else
        {
            Console.WriteLine("Сотрудник не найден!");
        }
        Console.WriteLine("\nИзменение названия библиотеки:");

        library.SetLibraryName("Городская библиотека №1");

        Console.WriteLine("Новое название: " + library.GetLibraryName());

        Console.WriteLine("\nРабота программы завершена.");
    }
}