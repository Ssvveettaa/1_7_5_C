// Задача 35:
// Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99].

// Пример для массива из 5, а не 123 элементов (в своём решении сделайте для 123):
// [ 5, 18, 123,  6,  2] –> 1
// [ 1,  2,   3,  6,  2] –> 0
// [10, 11,  12, 13, 14] –> 5

int[] CreateArrayRandomInt(int size, int min, int max)
{
    int[] arr = new int[size];
    var random = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = random.Next(min, max + 1);
    }
    return arr;
}

void OutputArray(int[] arr)
{
    Console.Write("[ ");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write(arr[i]);
    }
    Console.Write(" ]");
}

int CountTwoDigitNumbers(int[] arr, int start, int end)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] >= start && arr[i] <= end) count++;
    }
    return count;
}

Console.Write("Введите начало диапазона: ");
int startNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите конец диапазона: ");
int endNumber = Convert.ToInt32(Console.ReadLine());

// int[] array = { 5, 18, 123, 6, 2 }; // 1
// int[] array = { 1, 2, 3, 6, 2 }; // 0
// int[] array = { 10, 11, 12, 13, 14 }; // 5
int[] array = CreateArrayRandomInt(123, 1, 200);

OutputArray(array);
int result = CountTwoDigitNumbers(array, startNumber, endNumber);

Console.WriteLine($" –> {result}");
