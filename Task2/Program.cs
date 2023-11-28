// Задача 2: Задайте массив заполненный случайными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// Пример:
// [344 452 341 125] => 2

int size = SizeArray();
int[] arr = new int[size];

FillArrayRandomElements(arr, 100, 999);
PrintArray(arr, " ");

int count = countEvenNumbersInArray(arr);

Console.Write($" => ");

if (count == 0)
    Console.Write($"Четных чисел в массиве нет!");
else
    Console.Write($"{count} четных чисел в массиве.");

int SizeArray()
{
    Console.Write($"Введите размер массива -> ");
    return Convert.ToInt32(Console.ReadLine());
}

void FillArrayRandomElements(int[] array, int minValue, int maxValue)
{
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++)
        array[i] = rand.Next(minValue, maxValue + 1);

}

void PrintArray(int[] array, string separator) =>
    Console.Write($"[{string.Join(separator,array)}]");

int countEvenNumbersInArray(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) count++;
    }
    return count;
}
