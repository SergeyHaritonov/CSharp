// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0


Console.WriteLine("Введите размер массива: ");
int size = int.Parse(Console.ReadLine());

Console.WriteLine("Введите минимальное значение числа в массиве: ");
int minValue = int.Parse(Console.ReadLine());

Console.WriteLine("Введите максимальное значение числа в массиве: ");
int maxValue = int.Parse(Console.ReadLine());

int[] array = new int[size];

int[] FillArray(int size, int minValue, int maxValue)
{

    for (int i = 0; i < size; i++)

        array[i] = new Random().Next(minValue, maxValue);

    return array;
}

void OddElementsSum(int[] array)
{
    int sum = 0;

    for (int i = 1; i < size; i+=2)
    {
        sum = sum + array[i];
    }

    Console.WriteLine($"{String.Join(", ", array)} -> {sum}");
}

array = FillArray(size, minValue, maxValue);

OddElementsSum(array);

