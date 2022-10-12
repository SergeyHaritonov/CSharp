// Напишите программу, которая задаёт массив из введенного числа и выводит их на экран.
// Пользователь вводит число элементов в массиве и минимальное, и максимальное значение . 
// Надо заполнить массив рандоными данными от минимального до максимального значение .
// И важное уточнениее , делать все в методе который возвращает массив.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]


Console.WriteLine("Введите размер массива: ");
int arraySize = int.Parse(Console.ReadLine());

Console.WriteLine("Введите минимальное знаение массива: ");
int arrayMin = int.Parse(Console.ReadLine());

Console.WriteLine("Введите максимальное значение массива: ");
int arrayMax = int.Parse(Console.ReadLine());

int[] userArr(int size, int min, int max)
{
    int[] array = new int[arraySize];

    for (int i = 0; i < arraySize; i++)
    {
        array[i] = new Random().Next(arrayMin, arrayMax + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}
int[] array = userArr(arraySize, arrayMin, arrayMax);
PrintArray(array);