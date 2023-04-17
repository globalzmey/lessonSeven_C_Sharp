/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
            и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/

int[,] array = new int[3, 4];

FillRandom2DArray(array);

Console.Write("Введите номер строки: ");
int row = ReadNumberFromConsole();
Console.Write("Введите номер столбца: ");
int col = ReadNumberFromConsole();

FindElementOf2DArray(array, row, col);

Print2DArray(array);

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

int ReadNumberFromConsole()
{
    string? input = Console.ReadLine();
    return int.Parse(input);
}

void FindElementOf2DArray(int[,] array, int row, int col)
{
    if(row > 0 && col > 0)
    {
        if(row - 1 < array.GetLength(0) && col - 1 < array.GetLength(1))
        {
            Console.WriteLine($"Число в позиции строка: {row}, столбец: {col} = {array[row - 1, col - 1]}");
        }
        else
        {
            Console.WriteLine($"{row}{col} - такой позиции в массиве нет.");
        }
    }
    else
    {
        Console.WriteLine("Значения строки/столбца должны быть больше нуля.");
    }
}

void FillRandom2DArray(int[,] array)
{
    for(int m = 0; m < array.GetLength(0); m++)
    {
        for(int n = 0; n < array.GetLength(1); n++)
        {
            array[m, n] = new Random().Next(0, 9);
        }
    }
}