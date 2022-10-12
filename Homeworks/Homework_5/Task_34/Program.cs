// Задайте массив заполненный случайными положительными трёхзначными числами. 

// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2


Console.WriteLine("Введите размер массива: ");
int size = int.Parse(Console.ReadLine());

int[] array = new int[size];

int[] FillArray(int size)
{

    for (int i = 0; i < size; i++)

        array[i] = new Random().Next(100, 1000);

    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < size; i++)

        System.Console.Write($"{array[i]} ");
}

void PositiveNumber(int[] array)
{
    int result = 0;

    for (int i = 0; i < size; i++)
    {
        if (array[i] % 2 == 0)
        {
            result++;
        }
    }
    Console.WriteLine($"-> {result}");
}

array = FillArray(size);

PrintArray(array);

PositiveNumber(array);

