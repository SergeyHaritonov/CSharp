// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int result = 0;
int tmpnumber = 0;

if ((number > 99) && (number < 1000))
{
    tmpnumber = number / 10;
    result = tmpnumber % 10;
    Console.WriteLine($"Введённое число: {number} Вторая цифра числа: {result}");
}

else if ((number <= -100) && (number > -1000))
{
    tmpnumber = -number / 10;
    result = tmpnumber % 10;
    Console.WriteLine($"Введённое число: {number} Вторая цифра числа: {result}");
}

else{
    Console.WriteLine("Введите трёхзначное число");
}
