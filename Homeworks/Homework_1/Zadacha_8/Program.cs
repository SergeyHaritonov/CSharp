// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int startNumber = 1;

if(number <= startNumber)
{
    Console.WriteLine("Число не подходит под условия задачи");
}

    while(startNumber <= number)
    {
        if(startNumber % 2 == 0)
        {
            Console.Write(startNumber + " ");
        }

        startNumber++;
    }

