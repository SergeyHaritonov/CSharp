// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

// Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int i = 0;

// while (num > 0)
// {
//     num = num / 10;
//     i++;

// }

// Console.WriteLine(i);


// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

// void factorialDigit (string? data)

// {
//     ulong num;
//     while(true)
//     {
//         if(ulong.TryParse(data, out num))
//         {
//             break;
//         }
//         else
//         {
//             Console.WriteLine("Error to enter");
//             data = Console.ReadLine();
//         }
//     }
//     ulong result = 1;
//     for (ulong i = 2; i < num; i++)
//     {
//         result *=i;
//     }
//     Console.WriteLine($"произведение чисел {result}");
// }
// Console.WriteLine("Enter number");
// factorialDigit(Console.ReadLine());


// Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.

// int[] array = new int[8];

// for (int i = 0; i < 8; i++)
// {
//     array [i] = new Random().Next(0, 2);
//     Console.Write(array[i] + " ");
// }


Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int count = 0;

for (int i = 0; i <= num; i++)
{
    num = num / 10;
    ++i;
    count = i;
    Console.WriteLine(count);
}

// Console.WriteLine(count);

    