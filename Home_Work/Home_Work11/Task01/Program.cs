/*
Задача 3: 
Заданы 2 массива: info и data. 
В массиве info хранятся двоичные представления нескольких чисел (без разделителя). 
В массиве data хранится информация о количестве бит, которые занимают числа из массива info. 
Напишите программу, которая составит массив десятичных представлений чисел массива data 
с учётом информации из массива info.

входные данные:
    data = {0, 1, 1, 1, 1, 0, 0, 0, 1 }
    info = {2, 3, 3, 1 }

выходные данные:
    1, 7, 0, 1

*/


int[] data = { 0, 1, 1, 1, 1, 0, 0, 0, 1 };
int[] info = { 2, 3, 3, 1 };
int[] result = new int[info.Length];

void BinaryToDecimal(int[] data, int[] info) // преобразуем из 2-ой в 10-ую 
{
    int k = 0;  // счетчик количества цифр в data

    for (int i = 0; i < info.Length; i++)
    {
        for (int j = 0; j < info[i]; j++)
        {
            result[i] += data[k + j] * (int)Math.Pow(2, info[i] - 1 - j);

        }
        k += info[i];
    }
}

void PrintArr(int[] Mas) // Вывод массива
{
    int count = Mas.Length;
    for (int pos = 0; pos < count - 1; pos++)
    {
        Console.Write(Mas[pos] + "  ");
    }
    Console.WriteLine(Mas[Mas.Length - 1]);
}


BinaryToDecimal(data, info);
PrintArr(result);
