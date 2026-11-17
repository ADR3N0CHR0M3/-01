using System;

namespace MyLibrary
{
    public class LibraryMethods
    {
        public static void ShowStart()
        {
            Console.WriteLine("Библиотека успешно подключена!");
        }

        public static void ShowEnd()
        {
            Console.WriteLine("Работа программы завершена.");
        }

        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static double Divide(double a, double b)
        {
            return a / b;
        }

        public static string GetInfo()
        {
            return "MyLibrary - моя DLL-библиотека";
        }
    }
}