// Задача 47.Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5     7      -2     -0,2

//  1    -3,3      8     -9,9

//  8     7,8    -7,1      9



// Console.WriteLine("Введите количество строк массива: ");
// int rows = int.Parse(Console.ReadLine());

// Console.WriteLine("Введите количество столбцов массива: ");
// int columns = int.Parse(Console.ReadLine());

// double[,] CreateArray(int m, int n)
// {
//     double[,] array = new double[m, n];

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(-10, 10) + new Random().NextDouble();

//             Console.Write($"{Math.Round(array[i, j], 1)}; ");
//         }

//         Console.WriteLine();
//     }

//     return array;
// }

// CreateArray(rows, columns);



// Задача 50.Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,

// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17->такого числа в массиве нет



// Console.WriteLine("Введите номер строки элемента массива: ");
// int row = int.Parse(Console.ReadLine());

// Console.WriteLine("Введите номер столбца элемента массива: ");
// int column = int.Parse(Console.ReadLine());

// double[,] FindElementInArray(int minValue, int maxValue)
// {
//     double[,] array = new double[new Random().Next(4, 10), new Random().Next(4, 10)];

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)

//         {
//             array[i, j] = new Random().Next(1, 100);
//             Console.Write(array[i, j] + " ");
//         }
//         System.Console.WriteLine();
//     }

//     if (row <= array.GetLength(0) && column <= array.GetLength(1))

//         Console.WriteLine($"Значение элемента под данным индексом => {array[row, column]}");

//     else Console.WriteLine("Такого числа в массиве нет");

//     return array;
// }

// FindElementInArray(-10, 10);



// Задача 52.Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.



int[,] CreateArray()
{
    int[,] array = new int[new Random().Next(2, 6), new Random().Next(2, 6)];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)

        {
            array[i, j] = new Random().Next(1, 10);
            Console.Write(array[i, j] + " ");
        }
        System.Console.WriteLine();
    }

    return array;
}

void ArithmeticAverage(int[,] array)
{
    double average = 0;

    Console.WriteLine($"Среднее арифметическое каждого столбца:");

    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            average += array[i, j];
        }

        Console.Write($"{Math.Round(average / array.GetLength(0), 2)}  ");
        average = 0;
    }

}

ArithmeticAverage(CreateArray());