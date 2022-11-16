void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

Console.Write("Введите элементы(через пробел): ");
int[] newArr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int GetPositiveNum(int[] newArr)
{
    int count = 0;
    for(int i = 0; i < newArr.Length; i++)
    {
        if(newArr[i] > 0)
        {
            count++;
        }
    }
    return count;
}

Console.WriteLine($"The number of elements is greater than zero {GetPositiveNum(newArr)}");
ShowArray(newArr);



//Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями
// y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.



// Console.Write("Введите k1: ");
// double k1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите b1: ");
// double b1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите k2: ");
// double k2 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите b2: ");
// double b2 = Convert.ToDouble(Console.ReadLine());
 
 
// double x = -(b1 - b2) / (k1 - k2);
// double y = k1 * x + b1;
 
// x = Math.Round(x, 3);
// y = Math.Round(y, 3);
 
// Console.WriteLine($"Пересечение в точке: ({x};{y})");