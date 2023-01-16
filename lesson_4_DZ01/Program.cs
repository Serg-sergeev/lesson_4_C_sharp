// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int GetDegreeOfNumber(int number, int degreeOfNumber)
{
    int result = 1;

    for (int i = 1; i <= degreeOfNumber; i++)
    {
        result = result * number;
    }

    return result;
}

int GetNumber()
{
    int number;

    while(true)
    {
        string? input = Console.ReadLine();
        bool result = int.TryParse(input, out number);
        if (result == true)
        {
            break;
        }
        else
        {
            Console.Write("Попробуйте еще раз: ");
        }
    }

    return number;
}
Console.Write("Введите число, которое нужно возвести в степень: ");
int numberA = GetNumber();
Console.Write("Введите степень, в которую нужно возвести число " + numberA + " : ");
int numberB = GetNumber();

Console.WriteLine($"Число {numberA} в степени {numberB}: {GetDegreeOfNumber(numberA, numberB)}");