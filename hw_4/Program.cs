// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

/*Console.Write("Input the number: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Input the degree: ");
int b = Convert.ToInt32(Console.ReadLine());
int result = 1;

int NumDegree(int a, int b)
{
    int result =1;
    for (int i = 1; i <= b; i++)
    {
        result = result * a;
    }
    return result;
}

Console.WriteLine($"Число {a} в степени {b} - {NumDegree(a, b)}");
*/

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

/* Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int SumNumber(int value)
{
    int result = 0;
    while (value > 0)
    {
        result += value % 10;
        value  /= 10;
    }
    return result;
}
Console.WriteLine(SumNumber(number));
*/

// 452 -> 11

// 82 -> 10

// 9012 -> 12

// Задача 29: Напишите программу, которая задаёт массив из m элементов и выводит их на экран.

// Console.Write("Введите количесиво элементов в массиве:\t");
// int elCount = Convert.ToInt32(Console.ReadLine());

// int[] myArray = new int[elCount];

// Console.WriteLine("Вывод массива");

// for(int i = 0; i<myArray.Length; i++)
// {
//    Console.WriteLine(myArray[i]);
// }

Console.Write("Введите количесиво элементов в массиве:\t");
int m = Convert.ToInt32(Console.ReadLine());

int[] myArray = new int[m];


for (int i = 0; i < myArray.Length; i++)
{
    Console.Write(myArray[i]);
}

