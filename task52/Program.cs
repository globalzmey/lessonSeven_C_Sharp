/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

int[,] array = new int[3, 4];

FillRandom2DArray(array);
Print2DArray(array);

Console.Write("Среднее арифметическое каждого столбца: ");

for(int i = 0; i < array.GetLength(1) - 1; i++)
{
    PrintOfAverageColumn(array, i);
    Console.Write("; ");
}
PrintOfAverageColumn(array, array.GetLength(1) - 1);

Console.Write(".");

Console.WriteLine();

void PrintOfAverageColumn(int[,] array, int column)
{
    double accum = 0;

    for(int m = 0; m < array.GetLength(0); m++)
    {
        accum += array[m, column];
    }
    Console.Write(Math.Round(accum / array.GetLength(0), 1));
    //Console.Write("; ");
}

void Print2DArray(int[,] array)
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

void FillRandom2DArray(int[,] array)
{
    Random rnd = new Random();

    for(int m = 0; m < array.GetLength(0); m++)
    {
        for(int n = 0; n < array.GetLength(1); n++)
        {
            array[m, n] = rnd.Next(0, 9);
        }
    }
}