//Задача 19

//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

/*
Console.Write("Введите число: ");
int Number = Convert.ToInt32(Console.ReadLine());
int Reverse = 0;
int NumberCopy = Number;
    while(NumberCopy > 0)
    {  
        int remainder = NumberCopy % 10;
        Reverse = (Reverse * 10) + remainder;
        NumberCopy = NumberCopy / 10;
    } 
         if(Reverse == Number)
         {
          Console.WriteLine($"Число {Number} - Палиндром, ура! Наконец-то!" );  
         } 
         else
         Console.WriteLine($"Число {Number} - не фига не получилось!" ); 
          
         
 */

//Задача 21

//Напишите программу, которая принимает на вход координаты двух точек и находит 
//расстояние между ними в 3D пространстве.

// Видимо, сказываются мои значительные пробелы в математике - так и не победить мне эту задачу :( 

double FindDist (double x1, double x2, double y1, double y2, double z1, double z2)
{
    double catet1 = x2 - x1;
    double catet2 = y2 - y1;
    double catet3 = z2 - z1;
    
    double gipatenuza = Math.Sqrt(catet1 * catet1 + catet2 * catet2 + catet3 * catet3);
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

Console.Write("Введите координаты z1: ");
double z1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координаты z2: ");
double z2 = Convert.ToDouble(Console.ReadLine());



Console.WriteLine($"Ответ: {Math.Round(FindDist(x1, x2, y1, y2, z1, z2), 2)}");


/*
A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53
*/

//Задача 23

//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

/*
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= number; i++)
{
    double newIndex = Math.Pow(i, 3);
    Console.WriteLine(newIndex);
}
*/

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125