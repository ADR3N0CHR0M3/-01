using System;
using System.Collections.Generic;

namespace LibraryLib
{
    public class LibraryFunctions
    {
        // Название библиотеки
        private string libraryName = "Центральная городская библиотека Читы";

        // Главный библиотекарь
        private string chiefLibrarian = "Иванов Иван Иванович";

        // Список сотрудников
        private List<string> staff = new List<string>()
        {
            "Петрова Анна Сергеевна",
            "Сидоров Алексей Николаевич",
            "Кузнецова Мария Владимировна"
        };
        // Получение ФИО главного библиотекаря
        public string GetChiefLibrarian()
        {
            return chiefLibrarian;
        }

        // Получение названия библиотеки
        public string GetLibraryName()
        {
            return libraryName;
        }
        // Изменение названия библиотеки
        public void SetLibraryName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Название библиотеки не может быть пустым!");
            }

            libraryName = name;
        }
        // Изменение ФИО главного библиотекаря
        public void SetChiefLibrarian(string fullname)
        {
            if (string.IsNullOrWhiteSpace(fullname))
            {
                throw new ArgumentException("ФИО не может быть пустым!");
            }

            chiefLibrarian = fullname;
        }
        // Генерация уникального кода книги
        public string GenerateBookCode(string category, int number)
        {
            if (string.IsNullOrWhiteSpace(category))
            {
                throw new ArgumentException("Категория книги не может быть пустой!");
            }

            if (number <= 0)
            {
                throw new ArgumentException("Номер книги должен быть больше нуля!");
            }

            return $"{category.ToUpper()}-{number:D4}";
        }

        // Получение списка сотрудников
        public void AddStaff(string fullname)

        {
            if (string.IsNullOrWhiteSpace(fullname))
            {
                throw new ArgumentException("Имя сотрудника не может быть пустым!");
            }

            if (staff.Contains(fullname))
            {
                throw new ArgumentException("Такой сотрудник уже существует!");
            }

            staff.Add(fullname);
        }
        // Получение списка сотрудников
        public List<string> GetStaff()
        {
            return new List<string>(staff);
        }
        // Удаление сотрудника
        public void RemoveStaff(string fullname)
        {
            if (!staff.Contains(fullname))
            {
                throw new ArgumentException("Такой сотрудник не найден!");
            }

            staff.Remove(fullname);
        }


        // Поиск сотрудника
        public bool FindStaff(string fullname)
        {
            return staff.Contains(fullname);
        }
    }
}