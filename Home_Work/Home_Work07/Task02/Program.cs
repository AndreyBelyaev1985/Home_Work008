// Задача 2: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого
// элемента или же указание, что такого элемента нет.

int[,] RandArray(int row, int colum)
{

    int[,] array = new int[row, colum];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 100);

        }
    }

    return array;

}

void PrintArray(int[,] array)

{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]}\t");

        }
        System.Console.WriteLine();
    }

}

System.Console.WriteLine("Введите первую позицию элемента:  ");
int numberA = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите вторую позицию элемента:  ");
int numberB = Convert.ToInt32(Console.ReadLine());

void ReternValue(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == numberA && j == numberB)
                System.Console.WriteLine($"Значение элемента: {array[numberA, numberB]}");
                
        }
    }
}

void ReternValue2(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if ((numberA + 1) > array.GetLength(0) || (numberB + 1) > array.GetLength(1)) 

            System.Console.WriteLine($"Данное значение отсутствует");
            return;
        }
    }
}

int[,] Rnd = RandArray(5, 5);
PrintArray(Rnd);
System.Console.WriteLine();
ReternValue(Rnd);
ReternValue2(Rnd);
