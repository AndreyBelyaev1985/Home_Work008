/*Задача 2: Проверка на простое число:
N = 13 -> "Это простое число"
N = 12 -> “Это не простое число”*/

int Promt(string massage)
{
    Console.WriteLine(massage);
    int A = Convert.ToInt32(Console.ReadLine());
    return A;
}

void Division(int N, int B)
{
    if (N / B == 1)
    {
        Console.WriteLine("Это простое число ");
        return;
    }
    if (N % B != 0)
    {
        Division(N, B + 1);
    }
    else Console.WriteLine($" Это не простое число  ");
}

int A = Promt("Введите число: N ");
Division(A, 2);