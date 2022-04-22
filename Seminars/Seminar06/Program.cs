
//Задача 4: Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, 
//второй и предпоследний и т.д. Результат запишите в новом массиве.
//[1 2 3 4 5] -> 5 8 3
//[6 7 3 6] -> 36 21
int[] RandArray(int lenght)
{
    int[] answer = new int[lenght];
    for (int i = 0; i < lenght; i++)
    {
        answer[i] = new Random().Next(1, 5);
    }
    return answer;
}
void printArr(int[] Mas)
{
    int count = Mas.Length;
    for (int pos = 0; pos < count; pos++)
    {
        Console.Write(Mas[pos] + " ,");
    }
    Console.WriteLine();
}


int[] arr = RandArray(9);
printArr(arr);

int[] proizv(int[] arr)
{
    int length = arr.Length / 2;
    if (arr.Length % 2 == 1)
    {
        length++;
    }
    int[] result = new int[length];
    for (int i = 0; i < arr.Length / 2; i++)
    {
        result[i] = arr[i] * arr[arr.Length - i - 1];
    }
    result[result.Length - 1] = arr[result.Length - 1];
    return result;
}

printArr(proizv(arr));




//(Array[i], Array[Array.Length-(i+1)]) = (Array[Array.Length-(i+1)], Array[i]);
