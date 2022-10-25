/*
Задача 19

Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет
12821 -> да
23432 -> да
*/

/*
Задача 21

Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/


/*
Задача 23

Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

//Задача 23
// Напишите программу, которая принимает на вход координаты точки (X, Y), причеи X не 0 и Y не 0, 
//выдает номер четверти, в которой наодится эта точка

/*
int GetQuartNum(double x, double y)
{
    if(x > 0 && y > 0) return 1;
    if(x < 0 && y > 0) return 2;
    if(x < 0 && y < 0) return 3;
    if(x > 0 && y < 0) return 4;
    return 0;
}
Console.Write("Введите координату х: ");
double x = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату y: ");
double y = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"Ответ: {GetQuartNum(x, y)}");
*/

//Напишите программу, которая на вход принимает координаты двух точек и находит расстояние между ними
/*
double FindDist (double x1, double y1, double x2, double y2)
{
    double catet1 = x1 - x2;
    double catet2 = y1 - y2;
    double gipatenuza = Math.Sqrt(catet1 * catet1 + catet2 * catet2);
    return gipatenuza;
}
Console.Write("Введите координаты x1: ");
double x1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координаты x2: ");
double x2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координаты y1: ");
double y1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координаты y2: ");
double y2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"Ответ: {Math.Round(FindDist(x1, x2, y1, y2), 3)}");
*/

//Напишите программу, которая на вход принимает число N и выдает таблицу квадратов 
//от 1 до N

// void Table(int number) 
// {
//     int index = 0;
//     while (index <= number)
//     {
//         double result = Math.Pow(index, 2);
//         Console.Write(result + " ");
//         index++;
//     }
// }
// Console.WriteLine("Введите число: ");
// int result = Convert.ToInt32(Console.ReadLine());
// Table(result);