// Задача 3: Напишите программу, которая перевернёт одномерный массив 
// (первый элемент станет последним, второй – предпоследним и т.д.)
// Пример:
// [1 3 5 6 7 8] => [8 7 6 5 3 1]

int size = SizeArray();

int[] arr = new int[size];

FillArrayRandomElements(arr, 0, 100);
Console.Write($"Исходный массив - ");
PrintArray(arr, " ");
arr = ReversArray(arr);
Console.Write($" => Перевернутый массив - ");
PrintArray(arr, " ");

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
    Console.Write($"[{string.Join(separator, array)}]");

int[] ReversArray(int[] array)
{
    int tempElement;
    for (int i = 0; i < array.Length / 2; i++)
    {
        tempElement = array[i];
        array[i] = array[array.Length - 1 - i];
        array[array.Length - 1 - i] = tempElement;
    }
    return array;
}