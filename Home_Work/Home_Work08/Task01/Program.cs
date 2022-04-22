/*
Задача 1: 
Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию 
элементы каждой строки двумерного массива.
*/

int Prompt(string massage)
{
    System.Console.WriteLine(massage);
    int Value = Convert.ToInt32(Console.ReadLine());
    return Value;
}

void RandomArray(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
            System.Console.Write(array[i, j] + "\t");
        }
        System.Console.WriteLine();
    }

}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int[,] SortedRow(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            int min = array[i, j];

            for (int k = 0; k < array.GetLength(1); k++)
            {
                if (array[i, j] <= array[i, k])
                    continue;

                int temp = array[i, j];
                array[i, j] = array[i, k];
                array[i, k] = temp;
            }
        }
    }
    return array;
}

int m = Prompt("Введите количество строк в массиве: ");
int n = Prompt("Введите количество столбцов в массиве: ");
System.Console.WriteLine();

int[,] array = new int[m, n];
RandomArray(array);
SortedRow(array);
Console.WriteLine();
PrintArray(array);