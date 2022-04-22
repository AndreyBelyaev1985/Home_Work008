// Задача 1: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

double[,] RandArray(int row, int colum)
{
    double max = 50;
    double min = -40;
    double[,] array = new double[row, colum];

for (int i = 0; i < array.GetLength(0); i++)
{
    for(int j = 0; j < array.GetLength(1); j++)
    {
    array[i,j] = min + new Random().NextDouble() * (max-min);

    }
}

return array;

}

void PrintArray(double[,] array)
{
for(int i = 0; i < array.GetLength(0); i++)
{
    for (int j=0; j < array.GetLength(1); j++)
    {
        System.Console.Write($"{array[i,j]: 0.0}\t");
    
    }
    System.Console.WriteLine();
}






}

double[,] arr = RandArray(5,5);
PrintArray(arr);
