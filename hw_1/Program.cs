//Задача 2: 


//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

/*Console.Write("Ведите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Ведите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if(number1 > number2)
{
    Console.WriteLine($"число {number1} большее");
    Console.WriteLine($"число {number2} мешьшее");
}
else 
{
    Console.WriteLine($"число {number1} меньше");
    Console.WriteLine($"число {number2} больше");
}
*/

/*a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3*/

//Задача 4: 


//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

/*Console.Write("Ведите первое число: ");
int firstNum = Convert.ToInt32(Console.ReadLine());

Console.Write("Ведите второе число: ");
int secondNum = Convert.ToInt32(Console.ReadLine());

Console.Write("Ведите третье число: ");
int thirdNum = Convert.ToInt32(Console.ReadLine());

int max = firstNum;

if (firstNum > max)
{
 max = firstNum;
}
if (secondNum > max)
{
max = secondNum;
}
if (thirdNum > max)
{
max = thirdNum;
}

Console.WriteLine($"число {max} больше");

*/
/*2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

//Задача 6: 


//Напишите программу, которая на вход принимает число и выдаёт, 
//является ли число чётным (делится ли оно на два без остатка).


/*Console.Write("Ведите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 2 == 0) 
{
Console.WriteLine($"число {number} четное");
}
else 
{
    Console.WriteLine($"число {number} нечетное");
}
*/

/*4 -> да
-3 -> нет
7 -> нет
*/

//Задача 8:

// Напишите программу, которая на вход принимает число (N), 
//а на выходе показывает все чётные числа от 1 до N.

/*Console.Write("Ведите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int current = 1;

while(current <= number)
{
    if(current % 2 == 0)
    {
      Console.WriteLine(current);
    }
    current++;
}

*/

/*5 -> 2, 4
8 -> 2, 4, 6, 8
*/