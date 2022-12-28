
/*
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/
/*
int[,] CreateRandom2mArray()
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

void Print2mArray(int[,] array)
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

void Descending(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            for (int k = 0; k < array.GetLength(1) -1; k++)
                if(array[i, k] < array[i, k +1])
                {
                    int temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                }
}

int[,] myArray = CreateRandom2mArray();
Console.WriteLine("Исходный массив:");
Print2mArray(myArray);
Descending(myArray);
Console.WriteLine("Упоряпоченный массив:");
Print2mArray(myArray);
*/

/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/
/*
int[,] CreateRandom2mArray()
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



void Print2mArray(int[,] array)
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

int SmallestAmount(int[,] array)
{
    int num = 0;
    int sum = 0;
    int min = 99999999; // По другому пока не придумал)))
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            sum += array[i, j];
        if(sum < min)
        {
            min = sum; 
            num = i + 1;
        }    
        sum = 0;
    }
    return num;
}

int[,] myArray = CreateRandom2mArray();
Console.WriteLine("Ваш массив:");
Print2mArray(myArray);
Console.WriteLine($"Строка с наименьшей суммой элементов № {SmallestAmount(myArray)}.");
*/

/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

/*
Console.Write("Введите количество строк первой матрицы: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов первой матрицы и количество строк второй: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов второй матрицы: ");
int p = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите минимальное значение: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение: ");
int maxValue = Convert.ToInt32(Console.ReadLine());


int[,] firstMatrix = new int[m, n];
CreateArray(firstMatrix);
Console.WriteLine("Первая матрица:");
PrintArray(firstMatrix);

int[,] secondMatrix = new int[n, p];
CreateArray(secondMatrix);
Console.WriteLine("Вторая матрица:");
PrintArray(secondMatrix);

int[,] resultMatrix = new int[m, p];
ProductMatrix(firstMatrix, secondMatrix, resultMatrix);
Console.WriteLine("Произведение первой и второй матриц:");
PrintArray(resultMatrix);


void CreateArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1);
}


void ProductMatrix(int[,] firstMartrix, int[,] secomdMartrix, int[,] resultMatrix)
{
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < firstMartrix.GetLength(1); k++)
                sum += firstMartrix[i, k] * secomdMartrix[k, j];
            resultMatrix[i, j] = sum;
        }
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
*/

/*
Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/

/*
Console.WriteLine("Введите размер массива X x Y x Z:");
Console.Write("Введите X: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Y: ");
int y = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Z: ");
int z = Convert.ToInt32(Console.ReadLine());


int[,,] array3m = new int[x, y, z];
CreateArray(array3m);
WriteArray(array3m);

void CreateArray(int[,,] array3m)
{
    int[] tempo = new int[array3m.GetLength(0) * array3m.GetLength(1) * array3m.GetLength(2)];
    int number;
    for (int i = 0; i < tempo.GetLength(0); i++)
    {
        tempo[i] = new Random().Next(10, 100);
        number = tempo[i];
        if (i >= 1)
        {
            for (int j = 0; j < i; j++)
            {
                while (tempo[i] == tempo[j])
                {
                    tempo[i] = new Random().Next(10, 100);
                    j = 0;
                    number = tempo[i];
                }
                number = tempo[i];
            }
        }
    }
    int count = 0;
    for (int x = 0; x < array3m.GetLength(0); x++)
    {
        for (int y = 0; y < array3m.GetLength(1); y++)
        {
            for (int z = 0; z < array3m.GetLength(2); z++)
            {
                array3m[x, y, z] = tempo[count];
                count++;
            }
        }
    }
}

void WriteArray(int[,,] array3m)
{
    for (int i = 0; i < array3m.GetLength(0); i++)
    {
        for (int j = 0; j < array3m.GetLength(1); j++)
        {
            Console.Write($"X({i}) Y({j}) ");
            for (int k = 0; k < array3m.GetLength(2); k++)
            {
                Console.Write($"Z({k})={array3m[i, j, k]}; ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}
*/


/*
Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/
/*
Console.Write("Введите n, (n x n размер массива): ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] squareMatrix = new int[n, n];


int temp = 1;
int i = 0;
int j = 0;

while (temp <= squareMatrix.GetLength(0) * squareMatrix.GetLength(1))
{
    squareMatrix[i, j] = temp;
    temp++;
    if (i <= j + 1 && i + j < squareMatrix.GetLength(1) - 1) j++;
    else if (i < j && i + j >= squareMatrix.GetLength(0) - 1) i++;
    else if (i >= j && i + j > squareMatrix.GetLength(1) - 1) j--;
    else i--;
}

WriteArray(squareMatrix);

void WriteArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] / 10 <= 0)
                Console.Write($" {array[i, j]} ");
            else Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}
*/

