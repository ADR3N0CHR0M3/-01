using System;
using MyLibrary;

class Program
{
    static void Main()
    {
        LibraryMethods.ShowStart();

        int sum = LibraryMethods.Add(10, 5);
        Console.WriteLine("Сумма: " + sum);

        double result = LibraryMethods.Divide(10, 2);
        Console.WriteLine("Частное: " + result);

        string info = LibraryMethods.GetInfo();
        Console.WriteLine(info);

        LibraryMethods.ShowEnd();
    }
}