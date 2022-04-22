/* 
Задача 2:
Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.
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
        System.Console.Write(i + 1 + " :=>  ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
            System.Console.Write(" " + array[i, j] + "\t");
        }
        System.Console.WriteLine();
    }

}

void FoundMinRow(int[,] array)
{
    int MinSum = 0;
    int MinPos = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array[i, j];
        }
        if (sum < MinSum || MinSum == 0)
        {
            MinSum = sum;
            MinPos = i + 1;
        }
    }
    Console.WriteLine($"Минимальная сумма элементов в строке {MinPos} и равна {MinSum}");
}

int m = Prompt("Введите количество строк в массиве: ");
int n = Prompt("Введите количество столбцов в массиве: ");
System.Console.WriteLine();
int[,] array = new int[m, n];
RandomArray(array);
System.Console.WriteLine();
FoundMinRow(array);
