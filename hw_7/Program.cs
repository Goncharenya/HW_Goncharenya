int[,] CreateRandom2dArray(int row, int colums)
{
    int[,] array = new int[row, colums];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            array[i, j] = new Random().Next(0, 100);
        }
    }
    return array;
}


Console.Write("Введите количество рядов: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество колонок: ");
int n = Convert.ToInt32(Console.ReadLine());

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}



// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
/*

Console.Write("введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
double[,] numbers = new double[m, n];
FillArrayRandomNumbers(numbers);
PrintArray(numbers);

void FillArrayRandomNumbers(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
        }
    }
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write(" ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine(" ");
    }
}
*/

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
/*
Console.Write("Введите значение строки: ");
int rowValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение столбца: ");
int colValue = Convert.ToInt32(Console.ReadLine());

int[,] numbers = CreateRandom2dArray(n, m);

Console.WriteLine(numbers);
Show2dArray(numbers);

if(rowValue > numbers.GetLength(0) || colValue > numbers.GetLength(1))
{
    Console.WriteLine("Not fiend elements");
} else
{
    Console.WriteLine($"Значение элемента {rowValue} строки {colValue} равно {numbers[rowValue-1,colValue-1]}");
}

*/

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> числа с такими индексами в массиве нет

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
int[,] numbers = CreateRandom2dArray(m, n);

for (int j = 0; j < numbers.GetLength(1); j++)
{
    double avarage = 0;
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        avarage = (avarage + numbers[i, j]);
    }
    avarage = avarage / n;
    Console.Write(avarage + " ");
}


Show2dArray(numbers);
//Console.WriteLine();
