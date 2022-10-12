// Задача 54: Задайте двумерный массив. 

// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

// Например, задан массив:             В итоге получается вот такой массив:

//     1 4 7 2                                       7 4 2 1
//     5 9 2 3                                       9 5 3 2
//     8 4 2 4                                       8 4 4 2



int[,] array = new int[new Random().Next(4, 5), new Random().Next(4, 5)];

CreateArray(array);
PrintArray(array);

Console.WriteLine();

Ordering(array);
PrintArray(array);


void CreateArray(int[,] someArray)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void Ordering(int[,] someArray)
{
    {
        int temp;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                for (int k = 0; k < array.GetLength(1) - 1; k++)
                {
                    if (array[i, k] < array[i, k + 1])
                    {
                        temp = array[i, k + 1];
                        array[i, k + 1] = array[i, k];
                        array[i, k] = temp;
                    }
                }
            }
        }
    }
}

void PrintArray(int[,] someArray)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}




// Задача 56: Задайте прямоугольный двумерный массив. Напишите
// программу, которая будет находить строку с наименьшей суммой элементов.


// int[,] array = new int[new Random().Next(4, 5), new Random().Next(4, 5)];

// CreateArray(array);
// PrintArray(array);
// MinimumSum(array);




// void MinimumSum(int[,] someArray)
// {
//     int[] RowsSumArray = new int[someArray.GetLength(0)];

//     for (int i = 0; i < someArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < someArray.GetLength(1); j++)
//         {
//             RowsSumArray[i] += someArray[i, j];
//         }
//     }

//     int minimalSum = RowsSumArray[0];
//     int indexOfRow = 0;

//     for (int i = 1; i < RowsSumArray.Length; i++)
//     {
//         if (RowsSumArray[i] < minimalSum)
//         {
//             minimalSum = RowsSumArray[i];
//             indexOfRow = i;
//         }
//     }

//     Console.WriteLine($"Строка с наименьшей суммой элементов в массиве ({minimalSum}) -> {indexOfRow + 1}");
// }

// void CreateArray(int[,] someArray)
// {
//     for (int i = 0; i < someArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < someArray.GetLength(1); j++)
//         {
//             someArray[i, j] = new Random().Next(1, 10);
//         }
//     }
// }


// void PrintArray(int[,] someArray)
// {
//     for (int i = 0; i < someArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < someArray.GetLength(1); j++)
//         {
//             Console.Write(someArray[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }



// Задача 58: Задайте две матрицы. Напишите программу, которая будет
// находить произведение двух матриц.



// int m = SetNumbers("Введите число строк 1-й матрицы: ");
// int n = SetNumbers("Введите число столбцов 1-й матрицы (и строк 2-й): ");
// int p = SetNumbers("Введите число столбцов 2-й матрицы: ");
// int range = SetNumbers("Введите диапазон случайных чисел: от 1 до ");

// int[,] firstMartrix = new int[m, n];
// CreateArray(firstMartrix);
// Console.WriteLine($"Первая матрица:");
// PrintArray(firstMartrix);

// int[,] secomdMartrix = new int[n, p];
// CreateArray(secomdMartrix);
// Console.WriteLine($"Вторая матрица:");
// PrintArray(secomdMartrix);

// int[,] resultMatrix = new int[m,p];

// MultiplyMatrix(firstMartrix, secomdMartrix, resultMatrix);
// Console.WriteLine($"Произведение первой и второй матриц:");
// PrintArray(resultMatrix);

// void MultiplyMatrix(int[,] firstMartrix, int[,] secomdMartrix, int[,] resultMatrix)
// {
//   for (int i = 0; i < resultMatrix.GetLength(0); i++)
//   {
//     for (int j = 0; j < resultMatrix.GetLength(1); j++)
//     {
//       int sum = 0;
//       for (int k = 0; k < firstMartrix.GetLength(1); k++)
//       {
//         sum += firstMartrix[i,k] * secomdMartrix[k,j];
//       }
//       resultMatrix[i,j] = sum;
//     }
//   }
// }

// int SetNumbers(string input)
// {
//   Console.Write(input);
//   int output = Convert.ToInt32(Console.ReadLine());
//   return output;
// }

// void CreateArray(int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       array[i, j] = new Random().Next(range);
//     }
//   }
// }

// void PrintArray (int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       Console.Write(array[i,j] + " ");
//     }
//     Console.WriteLine();
//   }
// }



// Задача 60: Сформируйте трёхмерный массив из неповторяющихся
// двузначных чисел. Напишите программу, которая будет построчно выводить
// массив, добавляя индексы каждого элемента.


// Console.WriteLine($"Введите размер массива X на Y на Z:");
// int x = SetNumbers("Введите X: ");
// int y = SetNumbers("Введите Y: ");
// int z = SetNumbers("Введите Z: ");
// Console.WriteLine($"");

// int[,,] array3D = new int[x, y, z];
// CreateArray(array3D);
// WriteArray(array3D);

// int SetNumbers(string str)
// {
//   Console.Write(str);
//   int output = Convert.ToInt32(Console.ReadLine());
//   return output;
// }

// void WriteArray (int[,,] array3D)
// {
//   for (int i = 0; i < array3D.GetLength(0); i++)
//   {
//     for (int j = 0; j < array3D.GetLength(1); j++)
//     {
//       Console.Write($"X({i}) Y({j}) ");
//       for (int k = 0; k < array3D.GetLength(2); k++)
//       {
//         Console.Write( $"Z({k})={array3D[i,j,k]}; ");
//       }
//       Console.WriteLine();
//     }
//     Console.WriteLine();
//   }
// }

// void CreateArray(int[,,] array3D)
// {
//   int[] temp = new int[array3D.GetLength(0) * array3D.GetLength(1) * array3D.GetLength(2)];
//   int  number;
//   for (int i = 0; i < temp.GetLength(0); i++)
//   {
//     temp[i] = new Random().Next(10, 100);
//     number = temp[i];
//     if (i >= 1)
//     {
//       for (int j = 0; j < i; j++)
//       {
//         while (temp[i] == temp[j])
//         {
//           temp[i] = new Random().Next(10, 100);
//           j = 0;
//           number = temp[i];
//         }
//           number = temp[i];
//       }
//     }
//   }
//   int count = 0; 
//   for (int x = 0; x < array3D.GetLength(0); x++)
//   {
//     for (int y = 0; y < array3D.GetLength(1); y++)
//     {
//       for (int z = 0; z < array3D.GetLength(2); z++)
//       {
//         array3D[x, y, z] = temp[count];
//         count++;
//       }
//     }
//   }
// }


// Задача 62: Заполните спирально массив 4 на 4.


// int n = 4;
// int[,] array = new int[n, n];

// int tmp = 1;
// int i = 0;
// int j = 0;

// while (tmp <= array.GetLength(0) * array.GetLength(1))
// {
//   array[i, j] = tmp;
//   tmp++;
//   if (i <= j + 1 && i + j < array.GetLength(1) - 1)
//     j++;
//   else if (i < j && i + j >= array.GetLength(0) - 1)
//     i++;
//   else if (i >= j && i + j > array.GetLength(1) - 1)
//     j--;
//   else
//     i--;
// }

// PrintArray(array);

// void PrintArray (int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       if (array[i,j] / 10 <= 0)
//       Console.Write($" {array[i,j]} ");

//       else Console.Write($"{array[i,j]} ");
//     }
//     Console.WriteLine();
//   }
// }