// using System;

// namespace Seminar2
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Console.WriteLine("Hello World!");
//         }
//     }
// }


Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int lastNumber = 0;
int mediumNumber = 0;
int firstNumber = 0;

if(number > 0)
{
   lastNumber = number % 10;
   number /= 10;
   mediumNumber = number % 10;
   number /= 10;
   firstNumber = number;
}
string result = Convert.ToString(firstNumber) + Convert.ToString(lastNumber);
Console.WriteLine(result);


// Console.WriteLine("Введите первое число: ");
// int number1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите второе число: ");
// int number2 = Convert.ToInt32(Console.ReadLine());

// if (number1 % number2 == 0)
// {
//     Console.WriteLine("Второе число кратно первому");
// }
// else
// {
//     Console.WriteLine(number1 % number2);
// }
