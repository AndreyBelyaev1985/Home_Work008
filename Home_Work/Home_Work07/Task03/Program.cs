//Задача 3: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

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

void ArithmeticMean(int[,] array)
{
    double sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        System.Console.Write($"{sum / array.GetLength(0): 0.0};");
        sum = 0;
    }

}

int[,] dom = RandArray(5, 5);
PrintArray(dom);
System.Console.WriteLine();
System.Console.Write("Среднеарифметический каждого столбца  ");
ArithmeticMean(dom);
