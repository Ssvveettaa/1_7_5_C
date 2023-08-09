// Задача 37:
// Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний и т.д.
// Результат запишите в новом массиве.
// [1 2 3 4 5] –>  5  8  3
// [6 7 3 6]   –> 36 21

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

int[] ProductPairsElementsArray(int[] arr)
{
    int size = arr.Length / 2 + arr.Length % 2;
    int[] newArr = new int[size];
    for (int i = 0; i < size; i++)
    {
        newArr[i] = arr[i] * arr[arr.Length - 1 - i];
    }
    if (arr.Length % 2 == 1) newArr[size - 1] = arr[size - 1]; // arr[arr.Length / 2]
    return newArr;
}

Console.Write("Введите размер исходного массива: ");
int length = Convert.ToInt32(Console.ReadLine());

// int[] array = { 1, 2, 3, 4, 5 }; // 5 8 3
// int[] array = { 6, 7, 3, 6 }; // 36 21
int[] array = CreateArrayRandomInt(length, 1, 9);
int[] newArray = ProductPairsElementsArray(array);

OutputArray(array);
Console.Write(" –> ");
OutputArray(newArray);
