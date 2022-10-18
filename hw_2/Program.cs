/* Задача 10
Напишите программу, которая принимает на вход 
трёхзначное число и на выходе показывает вторую цифру этого числа.
*/

/*
int CutNum(int number)
{
    int result = (number/10) % 10;
    return result;
}
int randomNum = new Random().Next(100, 1000);
int resultNum = CutNum(randomNum);

Console.WriteLine($"новая версия числа {randomNum} следующая: {resultNum}");
*/

/*Задача 13
Напишите программу, которая выводит третью цифру заданного 
числа или сообщает, что третьей цифры нет.
*/

Console.Write("введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 99)
{
    Console.WriteLine("упс ... а неть :)");
}
if (number > 100 && number < 1000)
{
    int number1 = number%10;
    Console.WriteLine(number1);
}
if (number > 1000)
{
    int number2 = (number%100) /10;
    Console.WriteLine(number2);
}