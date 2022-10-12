// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76







// Не уверен, правильно ли я понял задачу. 
// Насколько я понял, вещественные числа - это все числа от минус бесконечности до бесконечности.
// Я не нашел как заполнить массив рандомными числами от минус бесконечности до бесконечности,
// поэтому границы массива вводит пользователь. Нагородил, как мне кажется, я прилично, но как уж получилось)


Console.WriteLine("Введите размер массива: ");
int size = int.Parse(Console.ReadLine());

Console.WriteLine("Введите минимальное значение числа в массиве: ");
double minValue = double.Parse(Console.ReadLine());

Console.WriteLine("Введите максимальное значение числа в массиве: ");
double maxValue = double.Parse(Console.ReadLine());

double[] array = new double[size];

double[] FillArray(int size)
{
    double[] arrayOne = new double[size];

    double[] arrayTwo = new double[size];

    for (int i = 0; i < size / 2; i++)
    {
        arrayOne[i] = new Random().NextDouble() * maxValue;
    }
    for (int j = 0; j < size / 2; j++)
    {
        arrayTwo[j] = new Random().NextDouble() * minValue;
    }

    double[] array = arrayOne.Union(arrayTwo).ToArray();
    
    //Это решение - единственное, что я придумал, чтобы элемент с индексом size / 2 был не 0.

    array[(size / 2)] = new Random().NextDouble() * minValue;

    return array;
}

void MaxMinusMin(double[] someArray)
{
    double minElement = array[0];

    double maxElement = array[0];

    for (int i = 0; i < size; i++)
    {
        if (array[i] > maxElement)
        {
            maxElement = array[i];
        }

        else if (array[i] < minElement)
        {
            minElement = array[i];
        }
        
    }

    Console.WriteLine($"max = {maxElement}");
    Console.WriteLine($"min = {minElement}");
    
    double result = Math.Abs(maxElement) - Math.Abs(minElement);
    
    Console.WriteLine($"В массиве [{String.Join(", ", array)}] разница между максимальным и минимальным элементом равна {result}");
}

array = FillArray(size);

MaxMinusMin(array);



