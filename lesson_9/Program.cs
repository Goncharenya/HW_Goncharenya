//Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.

// void ShowNums(int n)
// {
//     if (n > 1) ShowNums(n - 1);
//     Console.Write(n + " ");
// }

// ShowNums(5);

//Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.

// int Sum(int n)
// {
//   if(n != 0) return Sum(n / 10) + n % 10;
// return 0;
// }
// Console.Write(Sum(1525));

// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

// void ShowNums(int m, int n)
// {
//     if (m < n)
//     {
//          Console.Write($"{m}");
//         ShowNums(m + 1, n);
//     }
//     else if (m > n)
//     {
//         Console.Write($"{n}");
//         ShowNums(m, n+1);
//     }
// }
// Console.Write("input n: ");
// int n = Convert.ToInt32(Console.Read());
// Console.Write("input m: ");
// int m = Convert.ToInt32(Console.Read());
//ShowNums(1, 8);

// Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B.

double NumsPow(double num, double pow)
{
    if (pow > 0)
        return NumsPow(num, pow - 1) * num;

    else if (pow < 0)
        return NumsPow(num, pow + 1) / num;
    return 1;
}

Console.Write(NumsPow(2, 2));
