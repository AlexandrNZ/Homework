

/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет 
количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/
/*
Console.WriteLine("Введите количество элементов: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
ThreeValuedArray(size);
Console.WriteLine($"Ваш массив: ");
PrintArray(array);
Console.WriteLine($"Количество чётных чисел в массиве: {EvenNumbers(array)}");

int[] ThreeValuedArray(int size)
{
    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(100, 1000);
    return array;
}
int EvenNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
        if(array[i] % 2 == 0)
            count++;
    return count;
}
void PrintArray(int[] array)
{
    Console.Write("[ ");
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}
*/
/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/
/*
Console.Write("Введите количество элементов: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение: ");
int max = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
int sum = 0;
CreateRandomArray(size, min, max);
Console.WriteLine($"Ваш массив: ");
PrintArray(array);
OddPosition(array);

int[] CreateRandomArray(int size, int minValue, int maxValue) 
{
    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[ ");
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}

void OddPosition(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
    if(i % 2 != 0)
        sum = sum + array[i];
    }
    Console.WriteLine($"Всего {array.Length} чисел, сумма элементов на нечётных позициях = {sum}");
}
*/

/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/
/*
Console.Write("Введите количество элементов: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение: ");
int max = Convert.ToInt32(Console.ReadLine());
double[] array = new double[size];
DoubleArray(size, min, max);
Console.WriteLine($"Ваш массив: ");
PrintArray(array);
Difference(array);

double[] DoubleArray(int size, int min, int max)
{
    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max + 1);
        array[i] += new Random().NextDouble();
        array[i] = Math.Round(array[i], 3);
    }
    return array;
}

void PrintArray(double[] array)
{
    Console.Write("[ ");
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.Write("]");
    Console.WriteLine();
}

void Difference(double[] array)
{
    double min = double.MaxValue;
    double max = double.MinValue;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
            max = array[i];
        if (array[i] < min)
            min = array[i];
    }

Console.WriteLine($"всего {array.Length} чисел. Максимальное значение = {max}, минимальное значение = {min}");
Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");
}
*/

