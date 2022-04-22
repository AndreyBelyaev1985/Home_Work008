/*
Задача 4: 
Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
*/


int Prompt(string massage)
{
    System.Console.WriteLine(massage);
    int Value = Convert.ToInt32(Console.ReadLine());
    return Value;
}

int[,,] Fill3DArray(int line, int column, int layer)
{
    int[,,] array = new int[line, column, layer];
    int count = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = count;
                count++;
            }
        }
    }
    return array;
}

void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int k = 0; k < array.GetLength(2); k++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write($"({i},{j},{k}) => {array[i, j, k]}\t");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}


int x, y, z;
x = Prompt("Введите количество строк в  массиве: ");
y = Prompt("Введите количество столбцов в массиве: ");
z = Prompt("Введите количество слоев в массиве: ");

int[,,] Array = Fill3DArray(x, y, z);
    System.Console.WriteLine();
Console.WriteLine("Индекс массива ( , , ) => Значение элемента __");
    System.Console.WriteLine();
PrintArray(Array);
