try
{
    Console.WriteLine("КАЛЬКУЛЯТОР");

    Console.Write("Введите первое число: ");
    decimal a = Convert.ToDecimal(Console.ReadLine());

    Console.Write("Введите второе число: ");
    decimal b = Convert.ToDecimal(Console.ReadLine());

    Console.Write("Выберите операцию (+, -, *, /): ");
    string operation = Console.ReadLine();

    decimal result = 0;

    switch (operation)
    {
        case "+":
            result = a + b;
            break;

        case "-":
            result = a - b;
            break;

        case "*":
            result = a * b;
            break;

        case "/":
            result = a / b;
            break;

        default:
            Console.WriteLine("Неизвестная операция!");
            return;
    }

    Console.WriteLine($"Результат: {result}");
}
catch (FormatException)
{
    Console.WriteLine("Ошибка: необходимо вводить числа!");
}
catch (DivideByZeroException)
{
    Console.WriteLine("Ошибка: делить на ноль нельзя!");
}
catch (Exception ex)
{
    Console.WriteLine($"Произошла ошибка: {ex.Message}");
}
finally
{
    Console.WriteLine("Работа программы завершена.");
}