// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16


Console.WriteLine("Введите первое число: ");
int firstNumber = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int secondNumber = int.Parse(Console.ReadLine());

void degree(int num1, int num2)
{
    if (secondNumber > 0)
    {
        double result = Math.Pow(firstNumber, secondNumber);
        Console.WriteLine($"Число {firstNumber} в степени {secondNumber} равняется {result}");
    }
    else
    {
        Console.WriteLine("Второе число должно быть натуральным");
    }
    
}

degree(firstNumber, secondNumber);
