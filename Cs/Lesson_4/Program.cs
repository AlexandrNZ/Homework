/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16
*/
int PowerOfA(int A, int B)
{
    int result = 1;
    for (int i = 1; i <= B; i++) 
    {
        result *= A;
    }
    return result;
}
// Console.WriteLine("Введите число: ");
// int A = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите степень числа: ");
// int B = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Число {A} в степени {B} равно {PowerOfA(A, B)}");

/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12
*/

int SumOfDigits(int num)
{
    int sum = 0;
    if(num >=0)
    {
        while(num > 0)
        {
            sum += num % 10;
            num /= 10;
        }
        return sum;
    }
    else
    {
        num *= -1;
        while(num > 0)
        {
            sum += num % 10;
            num /= 10;
        }
        sum = -sum;
        return sum;
    }
}
// Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Сумма цифр числа {num} равна {SumOfDigits(num)}");

/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]
*/
void Array(int[] array)
{
    Console.WriteLine("Введте количество элементов в массиве: ");
    int amountofelements = Convert.ToInt32(Console.ReadLine());
    array = new int[amountofelements];
    int index = 0;
    while(index != amountofelements)
    {
        Console.WriteLine($"Введите элемент массива c индексом {index}: ");
        array[index] = Convert.ToInt32(Console.ReadLine());
        index++;
    }
    int indexprint = array.Length;
    int count = 0;
    Console.WriteLine($"Массив из {amountofelements} элементов");
    while(count < indexprint)
    {
        Console.Write(array[count]);
        count++;
    }

}
int[] array = new int [0];
Array(array);