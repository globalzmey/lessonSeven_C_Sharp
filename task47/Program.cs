/*
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
*/

int m = 3;
int n = 4;
double[,] array = new double[m, n];

FillRandom2DArray(array);
Print2DArray(array);

void Print2DArray(double[,] array)
{
    for(int m = 0; m < array.GetLength(0); m++)
    {
        Console.Write("|");
        for(int n = 0; n < array.GetLength(1) - 1; n++)
        {
            Console.Write($"{array[m, n]}, ");
        }
        Console.WriteLine(array[m, array.GetLength(1) - 1] + "|");
    }
}

void FillRandom2DArray(double[,] array)
{
    for(int m = 0; m < array.GetLength(0); m++)
    {
        for(int n = 0; n < array.GetLength(1); n++)
        {
            array[m, n] = Math.Round(new Random().Next(0, 99) + new Random().NextDouble(), 1);
        }
    }
}