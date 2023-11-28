// Задача 1: Напишите программу, которая бесконечно запрашивает целые числа с консоли. 
// Программа завершается при вводе символа ‘q’ или при вводе числа,
// сумма цифр которого четная.
// Пример
// 5 12 16 q [STOP]
// 3 45 342 15[STOP]

Console.WriteLine($"Вводите целые числа!");
Console.WriteLine($"Выход из программы когда, сумма цифр числа будет четной, либо клавиша Q");

while (true)
{
    Console.WriteLine($"Продолжить? Да - Enter. Нет - Q");
    ConsoleKeyInfo keyAny = Console.ReadKey();
    if (keyAny.Key == ConsoleKey.Q) break;
    if (keyAny.Key == ConsoleKey.Enter) 
    {
        int number = InputNumber();        
        if (isEvenSumDigitInNumber(SumDigitInNumber(number)) == true)
        {
            Console.WriteLine($"Сумма цифр числа = {SumDigitInNumber(number)}. Она четная, поэтому мы вышли из программы!");
            break;
        };
        ExplWhyNotExit(number);
    } 
}
Console.WriteLine("\nКонец программы");

int InputNumber()
{
    Console.Write($"Введите целое число -> ");
    return Convert.ToInt32(Console.ReadLine());
}

bool isEvenSumDigitInNumber(int sumDigit)
{
    return sumDigit % 2 == 0;
}

int SumDigitInNumber(int number)
{
    int sumDigit = 0;
    while (number > 0)
    {
        int lastDigit = number % 10;
        number /= 10;
        sumDigit += lastDigit;
    }
    return sumDigit;    
}

void ExplWhyNotExit(int number) =>
    Console.WriteLine($"Cумма цифр числа = {SumDigitInNumber(number)} нечетная!");
