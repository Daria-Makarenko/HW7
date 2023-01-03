// Домашняя работа 7

// Задача 1 - Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
/*
double [,] CreateRandom2dArray(int rows, int columns)
{
    double[,] array = new double[rows, columns];

    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().NextDouble();
        }
    }
    return array;
}

void Show2dArray(double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j]+ " ");

        Console.WriteLine();
    }
    Console.WriteLine();
}

 Console.Write("Input a number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());

double [,] myArray = CreateRandom2dArray(rows, columns);
Show2dArray(myArray);
*/

// Задача 2 -  Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
/*
int [,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];

    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return array;
}

void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");

        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.Write("Input a number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max value: ");
int max = Convert.ToInt32(Console.ReadLine());

void NumbersOrNot(int[,] array, int ri, int cj)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
        
            if(ri == i && cj == j)
            Console.Write(array[ri,cj]);
        }
    }
    if(ri > array.GetLength(0) || cj > array.GetLength(1))
     Console.WriteLine($"{ri} {cj} -> числа с такими индексами в массиве нет");
}

Console.Write("Input your number of row: ");
int Ri = Convert.ToInt32(Console.ReadLine());
Console.Write("Input your number of column: ");
int Cj = Convert.ToInt32(Console.ReadLine());

int [,] myArray = CreateRandom2dArray(rows, columns, min, max);
Show2dArray(myArray);

NumbersOrNot(myArray, Ri, Cj);
*/

// Задача 3 - Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
/*
int [,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];

    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return array;
}

Console.Write("Input a number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max value: ");
int max = Convert.ToInt32(Console.ReadLine());

void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");

        Console.WriteLine();
    }
    Console.WriteLine();
}

double[] SredArray(int[,] array)
{
    double Sred;
    double[] SrArray = new double[columns];
    for(int j = 0; j < array.GetLength(1); j++)
    {
        double Sum = 0;
        for(int i = 0; i < array.GetLength(0); i++)
        {
            Sum += array[i , j];
        }
        Sred = Sum / rows;
        SrArray[j] = Sred;
    }
    return SrArray;
}

void ShowArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        //Console.WriteLine($"array[{i + 1}] is {array[i]}");
        Console.Write(array[i] + " ");
    }
}


int [,] myArray = CreateRandom2dArray(rows, columns, min, max);
Show2dArray(myArray);

double[] result = SredArray(myArray);
ShowArray(result);
*/