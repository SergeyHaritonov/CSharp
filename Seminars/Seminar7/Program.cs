// Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. 
// Выведите полученный массив на экран.


// int[,] SomeMethod()
// {
//     Console.WriteLine("Введите количество строк: ");
//     int rows = int.Parse(Console.ReadLine());

//     Console.WriteLine("Введите количество столбцов: ");
//     int columns = int.Parse(Console.ReadLine());

//     int[,] mass = new int[rows, columns];

//     for (int i = 0; i < mass.GetLength(0); i++)
//     {
//         for (int j = 0; j < mass.GetLength(1); j++)
//         {
//             mass[i, j] = i + j;
//             Console.Write($"{mass[i, j]} ");
//         }
//         Console.WriteLine();
//     }

//     return mass;
// }

// SomeMethod();



// Задача 49: Задайте двумерный массив. Найдите элементы, у
// которых оба индекса чётные, и замените эти элементы на их
// квадраты.

// Например, изначально массив                 Новый массив будет выглядеть
//  выглядел вот так:                          вот так:

//     1 4 7 2                                     1 4 7 2
//     5 9 2 3                                     5 81 2 9
//     8 4 2 4                                     8 4 2 4



// int[,] GetArray()
// {

//     Console.WriteLine("Введите количество строк: ");
//     int rows = int.Parse(Console.ReadLine());

//     Console.WriteLine("Введите количество столбцов: ");
//     int columns = int.Parse(Console.ReadLine());

//     int[,] mass = new int[rows, columns];

//     for (int i = 0; i < mass.GetLength(0); i++)
//     {
//         for (int j = 0; j < mass.GetLength(1); j++)
//         {
//             mass[i, j] = new Random().Next(0, 10);
//             Console.Write($"{mass[i, j]} ");
//         }

//         Console.WriteLine();
//     }
//     Console.WriteLine();

//     for (int i = 0; i < mass.GetLength(0); i++)
//     {
//         for (int j = 0; j < mass.GetLength(1); j++)
//         {
//             if (i % 2 == 0 && j % 2 == 0)
//             {
//                 mass[i, j] *= mass[i, j];
//             }
//             Console.Write($"{mass[i, j]} ");
//         }
//         Console.WriteLine();

//     }

//     return mass;
// }

// GetArray();


// GetArray();

// int[,] GetArray()
// {
//     Console.WriteLine("Введите количество строк:");
//     int m = Convert.ToInt32(Console.ReadLine());

//     Console.WriteLine("Введите количество столбцов:");
//     int n = Convert.ToInt32(Console.ReadLine());

//     int[,] mass = new int[m,n];

//     for (int i = 0; i < mass.GetLength(0); i++)
//     {

//         for (int j = 0; j < mass.GetLength(1); j++)
//         {
//             mass[i, j] = new Random().Next(0, 100);
//             Console.Write($"{mass[i, j]} ");
//         }
//         Console.WriteLine();
//     }

//     Console.WriteLine();

//     for (int i = 0; i < mass.GetLength(0); i++)
//     {
//         for (int j = 0; j < mass.GetLength(1); j++)
//         {
//             if ( j % 2 == 0 && i % 2 == 0)
//             {
//                 mass[i, j] *= mass[i, j];
//             }
//             Console.Write($"{mass[i, j]} ");
//         }
//         Console.WriteLine();
//     }

//     return mass;
// }



// Задача 51: Задайте двумерный массив. Найдите сумму
// элементов, находящихся на главной диагонали (с индексами
// (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12





// int[,] GetNewArray()
// {
//     Console.WriteLine("Введите количество строк:");
//     int m = Convert.ToInt32(Console.ReadLine());

//     Console.WriteLine("Введите количество столбцов:");
//     int n = Convert.ToInt32(Console.ReadLine());

//     int[,] mass = new int[m, n];

//     for (int i = 0; i < mass.GetLength(0); i++)
//     {

//         for (int j = 0; j < mass.GetLength(1); j++)
//         {
//             mass[i, j] = new Random().Next(0, 100);
//             Console.Write($"{mass[i, j]} ");
//         }
//         Console.WriteLine();
//     }

//     Console.WriteLine();

//     return mass;
// }




// GetArray();



// Задача 51: Задайте двумерный массив. 
// Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.


int GetDiagonalArray()
{
    Console.WriteLine("Введите количество строк:");
    int row = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите количество столбцов:");
    int col = Convert.ToInt32(Console.ReadLine());

    int[,] mass = new int[row, col];

    int sum = 0;

    for (int i = 0; i < mass.GetLength(0); i++)
    {

        for (int j = 0; j < mass.GetLength(1); j++)
        {
            mass[i, j] = new Random().Next(0, 10);

            if (i == j)
            {
                sum += mass[i, j];
            }
            Console.Write($"{mass[i, j]} ");

            
        }
        Console.WriteLine();
        
    }

    System.Console.WriteLine();
    Console.WriteLine(sum);

    return sum;


}

GetDiagonalArray();


// Решение Коробкова
// GeNewArray();

// int GeNewArray()
// {
//     Console.WriteLine("Введите количество строк:");
//     int row = Convert.ToInt32(Console.ReadLine());

//     Console.WriteLine("Введите количество столбцов:");
//     int col = Convert.ToInt32(Console.ReadLine());

//     int[,] mass = new int[row,col];
//     int num1 = 0;

//     for (int i = 0; i < mass.GetLength(0); i++)
//     {

//         for (int j = 0; j < mass.GetLength(1); j++)
//         {
//             mass[i, j] = new Random().Next(0, 10);
//             if( i == j)
//             {
//                 num1 += mass[i, j];
//             }
//             Console.Write($"{mass[i, j]} ");
//         }
//         Console.WriteLine();
//     }

//      Console.WriteLine(num1);

//     return num1;
// }

