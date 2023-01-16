// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

long GetNumber()
{
    long number;
    while (true)
    {
        Console.Write("Введите число: ");
        string? input = Console.ReadLine();
        bool result = Int64.TryParse(input, out number);
        if (result == true)
        {
            break;
        }
        else
        {
            Console.WriteLine("Попробуйте еще раз!");
        }
    }

    return number;
}

long GetSumOfDigits(long number)
{
    long sum = 0;
    while (number != 0)
    {
        sum += number % 10;
        number = number / 10;
    }

    return sum;
}

long number = GetNumber();
Console.Write($"Суммы цифр в числе {number}: {GetSumOfDigits(number)}");