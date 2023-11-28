// Задача 1: Напишите программу, которая бесконечно запрашивает целые числа с консоли. 
// Программа завершается при вводе символа ‘q’ или при вводе числа,
// сумма цифр которого четная.
// Пример
// 5 12 16 q [STOP]
// 3 45 342 15[STOP]

using System.Reflection.Metadata.Ecma335;

Console.WriteLine($"Вводите целые числа!");
Console.WriteLine($"Выход из программы когда, сумма цифр числа будет четной, либо клавиша 'q'");

while (true)
{
    Console.Write("Введите число или 'q' для выхода => ");
    
    string? inputStr = Console.ReadLine();
    
    if (inputIsKeyQ(inputStr) == true)
    {
        Console.WriteLine("[STOP]");
        break;
    }

    if (int.TryParse(inputStr, out int number))
    {
        if (SumDigitInNumber(number) % 2 == 0)
        {
            Console.WriteLine("[STOP]");
            break;
        }
        ExplWhyNotExit(number);
    }
    else
        Console.WriteLine("Некорректный ввод. Введите целое число или 'q'.");
}

bool inputIsKeyQ(string input)
{
    if (input == "q") return true;
    else return false;
}

int SumDigitInNumber(int number)
{
    int sumDigit = 0;
        while (number > 0)
        {
            sumDigit += number % 10;
            number /= 10;
        }
    return sumDigit;
}

void ExplWhyNotExit(int number) =>
    Console.WriteLine($"Cумма цифр числа = {SumDigitInNumber(number)} нечетная!");
  
