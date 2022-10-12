// Задача 53: Задайте двумерный массив. 

// Напишите программу, которая поменяет местами первую и последнюю строку массива.


// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(0, 10);
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

// void NewArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (i == 0)
//             {
//                 int temp = array[array.GetLength(0) - 1, j];
//                 array[array.GetLength(0) - 1, j] = array[i, j];
//                 array[i, j] = temp;
//                 Console.Write(array[i, j] + " ");
//             }

//             else
//             {
//                 array[i, j] = array[i, j];
//                 Console.Write(array[i, j] + " ");
//             }
//         }
//         Console.WriteLine();
//     }
// }

// int[,] array = new int[3, 3];
// PrintArray(array);
// Console.WriteLine();
// NewArray(array);





// Задача 55: Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае, если это
// невозможно, программа должна вывести сообщение для
// пользователя.


// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(0, 10);
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

// int[,]RowsToColumns(int[,]array)
// {
//     int [,] NewRowArray = new int [array.GetLength(0),array.GetLength(1)];
//     System.Console.WriteLine("столбцы меняем местами со строками");
//     if (array.GetLength(0)==array.GetLength(1))
//     {
//         for (int i = 0; i < array.GetLength(0); i++)
//             {
//             for (int j = 0; j < array.GetLength(1); j++)
//                 {
//                     NewRowArray [i,j] = array[j,i];
//                     System.Console.Write($"{NewRowArray[i,j]}    ");
//                 } 
//                 System.Console.WriteLine();
//             }
//     }
//      else System.Console.WriteLine("impossible");
//     return NewRowArray;
// }




// Задача 57: Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных.


//     Набор данных                            Частотный массив

// { 1, 9, 9, 0, 2, 8, 0, 9 }              0 встречается 2 раза
//                                         1 встречается 1 раз
//                                         2 встречается 1 раз
//                                         8 встречается 1 раз
//                                         9 встречается 3 раза


//             1, 2, 3                     1 встречается 3 раза
//             4, 6, 1                     2 встречается 2 раз
//             2, 1, 6                     3 встречается 1 раз
//                                         4 встречается 1 раз
//                                         6 встречается 2 раза



// void GetArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(1, 10);
//         }
//     }
// }
// void PrintArray(int[,] array)
// {
//     Console.Clear();
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }
// Random rnd = new Random();
// int m = rnd.Next(6, 10);
// int n = rnd.Next(6, 10);
// int[,] array = new int[m, n];

// GetArray(array);
// PrintArray(array);
// Console.WriteLine();
// int trg = 0;
// int[,] dict = new int[m * n, 2];
// int k = 0;

// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         trg = 0;
//         for (int r = 0; r < k; r++)
//         {
//             if (dict[r, 0] == array[i, j])
//             {
//                 dict[r, 1]++;
//                 trg = 1;
//                 break;
//             }

//         }
//         if (trg == 0)
//         {
//             //dict = new int[k+1,2] (dict);
//             dict[k, 0] = array[i, j];
//             dict[k, 1]++;
//             k++;
//         }
//     }
// }

// for (int i = 0; i < k; i++)
// {
//     for (int j = 0; j < dict.GetLength(1); j++)
//     {
//         Console.Write($"{dict[i, j]} ");
//     }
//     System.Console.WriteLine();
// }


//Из двумерного массива целых чисел удалить строку и столбец, 
//на пересечении которых расположен первый найденный наименьший элемент.


// Console.Write("Введите количество строк массива: ");
// int rows = int.Parse(Console.ReadLine());
// Console.Write("Введите количество столбцов массива: ");
// int columns = int.Parse(Console.ReadLine());
// int[,] array = GetArray(rows, columns, 0, 10);
// PrintArray(array);
// Console.WriteLine();
// Console.WriteLine($"Минимальный элемент находится -> {String.Join(" ",GetIndexMinEl(array))}" );
// Console.WriteLine();
// PrintArray(GetResultArray(array, GetIndexMinEl(array)));

// int[,] GetArray(int m, int n, int min, int max)
// {
//     int[,] result = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             result[i, j] = new Random().Next(min, max + 1);
//         }

//     }
//     return result;
// }

// int[] GetIndexMinEl(int[,] inArray)
// {
//     int[] result = new int[]{0,0};
//     int min=inArray[0,0];
//     for (int i = 0; i < inArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < inArray.GetLength(1); j++)
//         {
//             if(min>inArray[i,j])
//             {
//                 min=inArray[i,j];
//                 result[0]=i;
//                 result[1]=j;
//             }
//         }
//     }
//     return result;
// }

// int[,] GetResultArray(int[,] inArray, int[] indexes)
// {
//     int[,] result = new int[inArray.GetLength(0) - 1, inArray.GetLength(1) - 1];
//     int row = 0;
//     int column = 0;
//     for (int i = 0; i < inArray.GetLength(0); i++)
//     {
//         if (i == indexes[0]) continue;
//         for (int j = 0; j < inArray.GetLength(1); j++)
//         {
//             if (j == indexes[1]) continue;
//             result[row, column] = inArray[i, j];
//             column++;
//         }
//         column = 0;
//         row++;
//     }
//     return result;
// }


// void PrintArray(int[,] inArray)
// {
//     for (int i = 0; i < inArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < inArray.GetLength(1); j++)
//         {
//             Console.Write($"{inArray[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// void PrintData(int[] inArray)
// {
//     int el = inArray[0];
//     int count = 1;
//     for (int i = 1; i < inArray.Length; i++)
//     {
//         if (inArray[i] != el)
//         {
//             Console.WriteLine($"{el} встречается {count}");
//             el = inArray[i];
//             count = 1;
//         }
//         else
//         {
//             count++;
//         }
//     }
//     Console.WriteLine($"{el} встречается {count}");
// }


// Вывести первые N строк треугольника Паскаля. Сделать вывод
// в виде равнобедренного треугольника


Console.Write("Введите нужное количество строк треугольника Паскаля: ");
int rows = int.Parse(Console.ReadLine());
PrintTriangle(rows);


void PrintTriangle(int n)
{
    for (int i = 0; i < n; i++)
    {
        for (int c = 0; c <= (n - i); c++) // создаём после каждой строки n-i отступов от левой стороны консоли, чем ниже строка, тем меньше отступ
        {
            Console.Write("  ");
        }
        for (int c = 0; c <= i; c++)
        {
            Console.Write("   "); // создаём пробелы между элементами треугольника
            Console.Write(factorial(i) / (factorial(c) * factorial(i - c))); //формула вычисления элементов треугольника
        }
        Console.WriteLine(); // после каждой строки с числами отступаем две пустые строчки
    }
}
float factorial(int n)
{
    float x = 1;
    for (int i = 1; i <= n; i++)
    {
        x *= i;
    }
    return x;
}