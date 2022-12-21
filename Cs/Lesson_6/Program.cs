/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/
/*
void Counter()
{
    Console.WriteLine("Введите сколько чисел хотите ввести: ");
    int M = Convert.ToInt32(Console.ReadLine());
    int count = 0;
    for (int i = 0; i < M; i++)
    {
        Console.WriteLine($"Введите {i + 1} число: ");
        int num = Convert.ToInt32(Console.ReadLine());
        if(num > 0)
            count++;
    }
    Console.WriteLine($"Количество значений больше 0 = {count}.");
}
Counter();
*/

/*
Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/
/*
Console.WriteLine("Введите значение b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());

if((k1 == k2) && (b1 == b2))
    Console.WriteLine("Прямые совпадают.");
else if(k1 == k2)
    Console.WriteLine("Прямые параллельны.");
else
{
double x = (-b2 + b1)/(-k1 + k2);
double y = k2 * x + b2;
Console.WriteLine($"Две прямые пересекутся в точке с координатами X: {x}, Y: {y}");
}
*/