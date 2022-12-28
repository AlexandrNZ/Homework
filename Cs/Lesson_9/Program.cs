/*
Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/
/*
void Sequence(int n)
{
    if(n >= 1)
    {
        Console.Write(n + " ");
        Sequence(n - 1);
    }
    
}
Console.Write("Задайте значение n: ");
int n = Convert.ToInt32(Console.ReadLine());
Sequence(n);
*/
/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

/*
int AmountInBetween(int m, int n)
{
    if(m <= n) return AmountInBetween(m, n-1) + n;
    else return 0;
}
Console.Write("Задайте значение m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте значение n: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write(AmountInBetween(m, n));
*/

/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/
/*
int Akkerman(int m, int n)
{
	if(m == 0) return n + 1;
	if(m > 0 && n == 0) return Akkerman(m - 1, 1);
	return Akkerman(m - 1, Akkerman(m, n - 1));
}
Console.Write("Задайте значение m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте значение n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write(Akkerman(m, n));
*/