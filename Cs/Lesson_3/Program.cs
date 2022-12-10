/*
Задача 19

Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да
*/
/*
bool Palindrome(int num)
{
    int temp = num;
    int rev = 0;
    while(num > 0)
    {
        int dig = num % 10;
        rev = rev * 10 + dig;
        num = num / 10;
    }
    if(temp == rev)
        return true;
    else
        return false;
}
Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
if(Palindrome(num)  == true)
    Console.WriteLine($"Число {num} является палиндромом ");
if(Palindrome(num)  == false)
    Console.WriteLine($"Число {num} не является палиндромом ");
*/

/*
Задача 21

Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53

double Distance(double xA, double yA, double zA, double xB, double yB, double zB )
{
    double length = Math.Sqrt(Math.Pow(xB - xA, 2) + Math.Pow(yB - yA, 2)+ Math.Pow(zB - zA, 2));
    return Math.Round(length, 2);
}
Console.WriteLine("Введите x-координату точки A: ");
double xA = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите y-координату точки A: ");
double yA = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите z-координату точки A: ");
double zA = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите x-координату точки B: ");
double xB = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите y-координату точки B: ");
double yB = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите z-координату точки B: ");
double zB = Convert.ToDouble(Console.ReadLine());

double distance_bet_ween_AB = Distance(xA, yA, zA, xB, yB, zB);
Console.WriteLine($"Расстояние между точками A и B равно {distance_bet_ween_AB}.");
*/

/*
Задача 23

Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125

void Сube(int num)
{
    int counter = 1;
    while(counter <= num)
    {
        Console.Write($"{Math.Pow(counter, 3)}");
        if(counter != num) Console.Write(", ");
        if(counter == num) Console.Write(". ");
        counter++;
    }
}
Console.Write("Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Таблица кубов чисел от 1 до {num}: ");
Сube(num);
*/

