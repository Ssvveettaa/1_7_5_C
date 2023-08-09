// Задача 33:
// Задайте массив.
// Напишите программу, которая определяет присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] –> нет
// 3; массив [6, 7, 19, 345, 3] –> да

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

bool SearchNumberArray(int[] arr, int num)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (num == arr[i]) return true;
    }
    return false;
}

Console.Write("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

// int[] array = { 6, 7, 19, 345, 3 };
int[] array = CreateArrayRandomInt(5, 0, 5);

// if (SearchNumberArray(array, number)) Console.Write($"Заданное число {number} присутствует в массиве: ");
// else Console.Write($"Заданное число {number} не присутствует в массиве: ");
// OutputArray(array);

Console.Write($"{number}; массив ");
OutputArray(array);

bool result = SearchNumberArray(array, number); // По сильной ссылке.
Console.WriteLine(result ? " –> да" : " –> нет");

// Console.WriteLine(SearchNumberArray(array, number) ? " –> да" : " –> нет"); // По слабой ссылке.
