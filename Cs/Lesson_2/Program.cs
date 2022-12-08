/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1


int Second_digit(int num)
{
   while(num > 99)
   {
    num = num / 10;
   }
   int result = num % 10;
   return result;
}
Console.WriteLine("Введите трёхзначное число:");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"В числе {num} вторая цифра {Second_digit(num)}");
*/

/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6


int Third_digit(int num)
{
   while(num > 999)
   {
    num = num / 10;
   }
   int result = num % 10;
   return result;
}

Console.WriteLine("Введите трёхзначное число:");
int num = Convert.ToInt32(Console.ReadLine());
if(num > 99)
{
    Console.WriteLine($"В числе {num} третья цифра {Third_digit(num)}");
}
else
{
    Console.WriteLine($"В числе {num} третьей цифры нет");
}
*/

/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет

Console.WriteLine("Введите цифру обозначающую день недели:");
int num = Convert.ToInt32(Console.ReadLine());
if(num > 0 & num < 8)
{
    if(num > 0 & num < 6)
    {
        Console.WriteLine("Это будний день.");
    }
    else
    {
        Console.WriteLine("Это выходной.");
    }
}
else
{
    Console.WriteLine("Вы ввели не ту цифру.");
}
*/