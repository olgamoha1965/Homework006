//Задача 41. Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

// Пользователь вводит количество чисел в массиве
/*
int [] CreatNewArray(int size)
{
    int [] array = new int [size];
    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(-10000, 10000);
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

int CountPosNum(int [] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0)
            count++;
        
    }
    return count;
}

Console.WriteLine("Input size of the array: ");
int size_uzer = Convert.ToInt32(Console.ReadLine());

int [] newarray = CreatNewArray(size_uzer);

ShowArray(newarray);

int res = CountPosNum(newarray);
Console.WriteLine();
Console.WriteLine($"Count positive numbers of array is {res}.");
*/

// Пользователь вводит количество чисел в массиве и элементы массива
/*
int [] CreatNewArray(int size)
{
    int [] array = new int [size];
    for(int i = 0; i < size; i++)
    {
        Console.WriteLine($"Input array elements at index {i}: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
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

int CountPosNum(int [] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0)
            count++;
        
    }
    return count;
}

Console.WriteLine("Input size of the array: ");
int size_uzer = Convert.ToInt32(Console.ReadLine());
int [] newarray = CreatNewArray(size_uzer);
ShowArray(newarray);

int res = CountPosNum(newarray);
Console.WriteLine($"Count positive numbers of array is {res}.");
*/

//Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
//значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

//y = k1 * x + b1
//y = k2 * x + b2
//k1 * x + b1 = k2 * x + b2
//k1 * x - k2 * x  = b2 - b1
// x * (k1 - k2) = b2 - b1
//x = (b2 - b1) / (k1 - k2)

//y = k1 * (b2 - b1) / (k1 - k2) + b1

/*double InterPoint(double k1, double b1, double k2, double b2)
{
    double x = 1;
    double y = 1;
    if(k1 == k2 && b1 == b2)
        Console.WriteLine("Lines coincide.");
    else
        if(k1 == k2)
            Console.WriteLine("lines are parallel.");
        if(k1 != k2)
        {
            x = Math.Round((b2 - b1) / (k1 - k2), 2);
            y = k1 * x + b1;
            Console.WriteLine($"Intersection point -> ({x}; {y})");
        }
    return x;
}

Console.WriteLine("Input first number for first equation: ");
double first_1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input second number for first equation: ");
double second_1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input first number for second equation: ");
double first_2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input second number for second equation: ");
double second_2 = Convert.ToInt32(Console.ReadLine());

InterPoint(first_1, second_1, first_2, second_2);
*/






