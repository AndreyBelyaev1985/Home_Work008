/* Задача №3 Заданы два массива: Info и data. В Массиве Info хранятся двоичные представления нескольких чисел (без разделителей).
В массиве data хранится информация о колличестве бит, которые занимают числа из массива info. Напишите програму, которая составит 
массив десятичных представленний чисел массива data с учётом информации из массива info.

Входные данные: 

data = {0,1,1,1,1,0,0,0,1}
info = {2,3,3,1}

Выходные данные:
1,7,0,1. */

void PrintArrya(int[] Mas)
{
    int count = Mas.Length;
    for (int i = 0; i < count - 1; i++)
    {
        Console.Write(Mas[i] + ", ");

    }
    Console.WriteLine(Mas[Mas.Length - 1]);
}

void BinaryToDecimal(int[] data, int[] info, int begin = 0, int count = 0)
{
    if (begin >= data.Length)
        return;
    int c = info[count];
    int temp = 0;
    for (int i = 0; i < c; i++)
    {
        temp = temp + data[begin + c - i - 1] * Powering(2, i);
    }
    info[count] = temp;
    BinaryToDecimal(data, info, begin + c, count + 1);
}

int Powering(int b, int a)
{
    if (a <= 0)
        return 1;
    return b * Powering(b, a - 1);
}



int[] data = { 0, 1, 1, 1, 1, 0, 0, 0, 1 };
int[] info = { 2, 3, 3, 1 };

BinaryToDecimal(data, info);
PrintArrya(info);
