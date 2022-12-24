/*
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/
/*
double[,] TwoDimensionalArray()
{
    Console.Write("Введите количество строк: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество столбцов: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите минимальное значение: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите максимальное значение: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    double[,] array = new double[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue + 1);
            array[i, j] += new Random().NextDouble();
            array[i, j] = Math.Round(array[i, j], 3);
        }
    return array;
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.Write("] ");
        Console.WriteLine();
    }
    Console.WriteLine();
}
PrintArray(TwoDimensionalArray());
*/
/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
1 7 -> числа с такими индексами в массиве нет
*/
/*
int[,] CreateRandomArray()
{
    Console.Write("Введите количество строк: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество столбцов: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите минимальное значение: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите максимальное значение: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1);
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.Write("] ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

void IndexDeterminant(int[,] array)
{
    Console.WriteLine("Введите индекс элемента в строке: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите индекс элемента в столбце: ");
    int columns = Convert.ToInt32(Console.ReadLine());

    if (rows > array.GetLength(0) && columns > array.GetLength(1))
        Console.WriteLine($"Элемента с индексом {rows} {columns} в массиве нет.");
    else
        Console.WriteLine($"Значение элемента под индексом {rows} {columns} - {array[rows, columns]}");
}

int[,] myArray = CreateRandomArray();
PrintArray(myArray);
IndexDeterminant(myArray);
*/


/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/
/*
int[,] CreateRandomArray()
{
    Console.Write("Введите количество строк: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество столбцов: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите минимальное значение: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите максимальное значение: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1);
    return array;
}

void PrintArray(int[,] array)
{
    Console.WriteLine("Ваш массив: ");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.Write("] ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

void Average(int[,] array)
{
    double[] averageArray = new double[array.GetLength(1)];
    for (int i = 0; i < array.GetLength(1); i++)
    {
        double sum = 0;
        for (int j = 0; j < array.GetLength(0); j++)
            sum += array[j, i];
        averageArray[i] = sum / array.GetLength(0);
    }
    Console.WriteLine("Среднее арифмитическое столбцов: ");
    Console.Write("[ ");
    for (int i = 0; i < averageArray.Length; i++)
        Console.Write(averageArray[i] + " ");
    Console.Write("]");
}


int[,] myArray = CreateRandomArray();
PrintArray(myArray);
Average(myArray);
*/