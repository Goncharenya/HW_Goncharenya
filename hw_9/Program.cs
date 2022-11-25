// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// void ShowNumbers(int num)
// {
//     if (num > 0)
//     {
//          Console.Write(num + " ");
//          ShowNumbers(num - 1);
//        }
// }
// ShowNumbers(5);



// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.


// int SumNumbers(int m, int n)
// {
//     if (m == 0)
//         return (n * (n + 1)) / 2;
//     else if (n == 0)
//         return (m * (m + 1)) / 2;
//     else if (m == n)
//         return m;
//     else if (m < n)
//         return n + SumNumbers(m, n - 1);
//     else
//         return n + SumNumbers(m, n + 1);
// }


Console.Write("input the m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("input the n: ");
int n = Convert.ToInt32(Console.ReadLine());
//  Console.Write(SumNumbers(m, n));


// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

void AkkermanFunction(int m, int n)
{
    Console.Write(Akkerman(m, n)); 
}

// функция Аккермана
int Akkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return Akkerman(m - 1, 1);
    }
    else
    {
        return (Akkerman(m - 1, Akkerman(m, n - 1)));
    }
}


// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29