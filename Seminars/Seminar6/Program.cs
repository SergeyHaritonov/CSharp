// Задача 40: Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.


// Console.WriteLine("Введите длину первой стороны: ");
// int number1 = int.Parse(Console.ReadLine());

// Console.WriteLine("Введите длину второй стороны: ");
// int number2 = int.Parse(Console.ReadLine());

// Console.WriteLine("Введите длину третьей стороны: ");
// int number3 = int.Parse(Console.ReadLine());

// void Triangle()
// {
//     if (number1 < (number2 + number3) && number2 < (number1 + number3) && number3 < (number1 + number2))
//     {
//         Console.WriteLine("Да");
//     }

//     else Console.WriteLine("Нет");
// }

// Triangle();



// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10


// Console.WriteLine("Введите число: ");
// int num = int.Parse(Console.ReadLine());

// bool[] array = Num2(num);

// Console.WriteLine(String.Join("", array));

// for (int i = 0; i < array.Length; i++)
// {
//     Console.Write(Convert.ToInt32(array[i]));
// }

// bool[] Num2(int num)
// {
//     int result = 0;
//     bool[] arr = new bool[32];

//     for (int i = 0; num > 0; i++)
//     {
//         result = num % 2;
//         num = num / 2;
//         arr[arr.Length - 1 - i] = Convert.ToBoolean(result);
//     }

//     return arr;
// }



// Задача 44:
// Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 --> 0 1 1 2 3
// Если N = 3 --> 0 1 1
// Если N = 7 --> 0 1 1 2 3 5 8


// Console.WriteLine("Введите число: ");
// int n = int.Parse(Console.ReadLine());

// f(n) = f(n-1) + f(n-2)


// void Fibonacci()
// {
//     int num = 0;

//     int num1 = 1;

//     int result = 0;

//     Console.WriteLine("Введите число: ");

//     int N = Convert.ToInt32(Console.ReadLine());
    
//     Console.WriteLine($"{num} {num1}");

//     for (int i = 1; i < N; i++)
//     {
        
//         result = num + num1;
//         num = num1;
//         num1 = result;
        
//         Console.Write($", {result}");
//     }


// }

// Fibonacci();



// Задача 45: Напишите программу, которая будет создавать
// копию заданного массива с помощью поэлементного
// копирования. 




int[] Massive()
{
    Console.WriteLine("Введите размер массива: ");

    int i1 = int.Parse(Console.ReadLine());

    int[] mass = new int[i1];

    for (int i = 0; i < mass.Length; i++)
    {
        mass[i] = new Random().Next(-10, 10);
    }

    Console.WriteLine(String.Join(",", mass));

    int[] mass1 = new int[i1];

    for (int j = 0; j < mass1.Length; j++)
    {
        mass1[j] = mass[j];
    }

    Console.WriteLine(String.Join(",", mass1));

    return mass1;
}

Massive();