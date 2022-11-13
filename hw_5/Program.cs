int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}


// Console.Write("Введите количество элементов: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите минимальное значение элементов: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите максимальное значение элементов: ");
// int max = Convert.ToInt32(Console.ReadLine());



// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
//которая покажет количество чётных чисел в массиве.

// int Count(int[] myArray)
// {
//     int count = 0;
//     for(int i = 0; i<myArray.Length; i++)
//     {
//         if(myArray[i] % 2 == 0)
//         {
//             count++;
//         }
//     }
//     return count;
// }

// int[] myArray = CreateRandomArray(n, min, max);
// ShowArray(myArray);

// Console.WriteLine(Count(myArray));


// [345, 897, 568, 234] -> 2

// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.

// int SumNegIndex(int[] array)
// {
//     int sum = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (i % 2 != 0)
//         {
//             sum = array[i] + sum;
//         }
//     }
//     return sum;
// }
// int[] array = CreateRandomArray(n, min, max);
// ShowArray(array);
// Console.WriteLine("сумма:" + SumNegIndex(array));



// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.


int GetDiff(int[] Array)
{
    int minArray = 0;
    int maxArray = 0;
    int diff = 0;

    for (int i = 0; i < Array.Length; i++)
    {

        if (Array[i] > maxArray)
        {
            maxArray = Array[i];
        }

        if (Array[i] < minArray)
        {
            minArray = Array[i];
        }
    }
    
    diff = maxArray - minArray;

    return diff;
}
int[] Array = {3, 7, 22, 2, 8};

//int[] Array = CreateRandomArray(n, min, max);
ShowArray(Array);
Console.WriteLine("разница равна: " + GetDiff(Array));



