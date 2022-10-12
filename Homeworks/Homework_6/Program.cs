// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.



// void NumbersAboveZero()
// {
//     Console.Write("Введите элементы(через пробел): ");

//     string numbersString = Console.ReadLine();

//     string[] numbersStringArray = numbersString.Split(" ", StringSplitOptions.RemoveEmptyEntries);

//     int[] numbersArray = new int[numbersStringArray.Length];

//     int count = 0;

//     for (int i = 0; i < numbersStringArray.Length; i++)
//     {
//         numbersArray[i] = int.Parse(numbersStringArray[i]);

//         if (numbersArray[i] > 0) count++;
//     }

//     Console.Write($"Количество чисел больше 0 -> " + count);

// }

// NumbersAboveZero();





// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 

// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


void PointOfCrossing()
{
    Console.WriteLine("Введите значение k1: ");
    double k1 = Double.Parse(Console.ReadLine());

    Console.WriteLine("Введите значение b1: ");
    double b1 = Double.Parse(Console.ReadLine());

    Console.WriteLine("Введите значение k2: ");
    double k2 = Double.Parse(Console.ReadLine());

    Console.WriteLine("Введите значение b2: ");
    double b2 = Double.Parse(Console.ReadLine());

    if (k1 == k2 && b1 == b2) Console.WriteLine("Прямые совпадают");
    else if (k1 == k2) Console.WriteLine("Прямые параллельны и никогда не пересекутся");
    else
    {

        double x = (b1 - b2) / (k2 - k1);
        double y = ((k2 * b1) - (k1 * b2)) / (k2 - k1);

        Console.WriteLine($"Точка пересечения двух прямых с указанными коэффициентами -> {x}; {y}");
    }

}

PointOfCrossing();



