/*
Задача 3: 
Задайте две матрицы. 
Напишите программу, которая будет находить произведение двух матриц.
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

int[,] ProductTwoMatrices(int[,] firstMatrix, int[,] secondMatrix) 
{
    int[,] productMatrix = new int[firstMatrix.GetLength(0), secondMatrix.GetLength(1)];
    
    for (int i = 0; i < firstMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < secondMatrix.GetLength(1); j++)
        {
            for (int k = 0; k < firstMatrix.GetLength(1); k++)
            {
                productMatrix[i, j] += firstMatrix[i, k] * secondMatrix[k, j];
            }
        }
    }
    return productMatrix;
}

int m1, m2, n1, n2;
 m1 = Prompt("Введите количество строк в первом массиве: ");
 n1 = Prompt("Введите количество столбцов в первом массиве: ");

 m2 = Prompt("Введите количество строк во втором массиве: ");
 n2 = Prompt("Введите количество столбцов во втором массиве: ");

if (n1 != m2)
{
    System.Console.WriteLine("Невозможно найти произведение матриц. Количество столбцов первого массива должно равняться количеству строк второго массива.");
}

if (n1 == m2)
{
System.Console.WriteLine();
int[,] FirstArray = new int[m1, n1];
RandomArray(FirstArray);

System.Console.WriteLine();
int[,] SecondArray = new int[m2, n2];
RandomArray(SecondArray);
System.Console.WriteLine();

int[,] ProductArray = ProductTwoMatrices (FirstArray, SecondArray);
PrintArray(ProductArray);
}
