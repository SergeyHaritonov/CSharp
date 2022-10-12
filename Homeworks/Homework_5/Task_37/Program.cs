// Найдите произведение пар чисел в одномерном массиве. 

// Парой считаем первый и последний элемент, второй и предпоследний и т.д. 

// Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21


Console.WriteLine("Введите размер массива: ");
int size = int.Parse(Console.ReadLine());

Console.WriteLine("Введите минимальное значение числа в массиве: ");
int minValue = int.Parse(Console.ReadLine());

Console.WriteLine("Введите максимальное значение числа в массиве: ");
int maxValue = int.Parse(Console.ReadLine());

int[] FillArray()
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue);

        Console.Write($"{array[i]} ");

    }

    Console.WriteLine();

    return array;
}


int[] NumberPairs(int[] array)
{
    int newSize = array.Length / 2;

    if (array.Length % 2 == 1)
    {
        newSize = newSize + 1;
    }

    int[] newArray = new int[newSize];

    for (int i = 0; i < newSize; i++)
    {
        if (newSize % 2 == 1)
        {
            newArray[i] = array[i] * array[array.Length - 1 - i];

            newArray[newArray.Length - 1] = array[size / 2];
        }

        if (newSize % 2 == 0)
        {
            newArray[newArray.Length - 1] = array[size / 2];

            newArray[i] = array[i] * array[array.Length - 1 - i];
        }

        Console.Write($"{newArray[i]} ");
    }

    return newArray;
}

NumberPairs(FillArray());

