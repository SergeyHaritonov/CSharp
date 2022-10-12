//Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
//Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.
// namespace Seminar5;
// class Program
// {
//     static void GetSum (int[] array)
//     {
//         int posSum = 0, 
//         negSum = 0;
//         for (int i = 0; i < array.Length; i++)
//         {
//             if (array[i] >= 0)
//             posSum += array[i];            
//             else
//             negSum += array[i];
//         }
//         System.Console.WriteLine($"\nСумма положительных чисел = {posSum}.\nСумма отрицательных = {negSum}.");
//     }

//     static int[] FillArray (int size, int min, int max)
//     {
//         int[] array = new int[size];
//         for (int i = 0; i < array.Length; i++)
//             array[i] = new Random().Next(min, max);
//         return array;
//     }

//     static void PrintArray (int[] array)
//     {
//         for (int i = 0; i < array.Length; i++)
//             System.Console.Write($"{array[i]} ");
//     }

//     static void Main(string[] args)
//     {
//         int[] array = FillArray(12, -20, 20);
//         PrintArray(array);
//         GetSum(array);
//     }
// }




// Общее обсуждение решения
// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 

// namespace Seminar5._1;
// class Program
// {
//     static int[] ReverseArray (int[] array)
//     {
//         for (int i = 0; i < array.Length; i++)
//             array[i] *= (-1);
//         return array;
//     }

//     static int[] FillArray (int size, int min, int max)
//     {
//         int[] array = new int[size];
//         for (int i = 0; i < array.Length; i++)
//             array[i] = new Random().Next(min, max);
//         return array;
//     }

//     static void PrintArray (int[] array)
//     {
//         for (int i = 0; i < array.Length; i++)
//             System.Console.Write($"{array[i]} ");
//     }

//     static void Main(string[] args)
//     {
//         int[] array = FillArray(20, -99, 100);
//         PrintArray(array);
//         array = ReverseArray(array);
//         System.Console.WriteLine();
//         PrintArray(array);
//     }
// }



// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да
// namespace Seminar5._2;
// class Program
// {    
//     static bool FindValue (int[] array, int value)
//     {
//         bool isFind = false;
//         for (int i = 0; i < array.Length; i++)
//             if (array[i] == value) 
//                 isFind = true; 
//         return isFind;
//     }

//     static int[] FillArray (int size, int min, int max)
//     {
//         int[] array = new int[size];
//         for (int i = 0; i < array.Length; i++)
//             array[i] = new Random().Next(min, max);
//         return array;
//     }

//     static void PrintArray (int[] array)
//     {
//         for (int i = 0; i < array.Length; i++)
//             System.Console.Write($"{array[i]} ");
//     }

//     static void Main(string[] args)
//     {
//         System.Console.WriteLine("Введите искомое число");
//         int value = Convert.ToInt32(System.Console.ReadLine());
//         int[] array = FillArray(40, -99, 100);
//         PrintArray(array);
//         bool valueIsFind = FindValue(array, value);
//         System.Console.WriteLine();
//         if (valueIsFind)
//             System.Console.WriteLine("Число найдено");
//         else
//             System.Console.WriteLine("Число не найдено");

//     }
// }


// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

// namespace Seminar5._3;
// class Program
// {    
//     static int FindEntrance (int[] array, int min, int max)
//     {
//         int count = 0;
//         for (int i = 0; i < array.Length; i++)
//             if (array[i] >= min && array[i] <= max) 
//                 count++; 
//         return count;
//     }

//     static int[] FillArray (int size, int min, int max)
//     {
//         int[] array = new int[size];
//         for (int i = 0; i < array.Length; i++)
//             array[i] = new Random().Next(min, max);
//         return array;
//     }

//     static void PrintArray (int[] array)
//     {
//         for (int i = 0; i < array.Length; i++)
//             System.Console.Write($"{array[i]} ");
//     }

//     static void Main(string[] args)
//     {
//         int[] array = FillArray(123, 0, 1000);
//         PrintArray(array);
//         int count = FindEntrance(array, 10, 99);
//         System.Console.WriteLine($"\nЧисло вхождений в массив чисел в диапазоне от 10 до 99 = {count}");
//     }
// }