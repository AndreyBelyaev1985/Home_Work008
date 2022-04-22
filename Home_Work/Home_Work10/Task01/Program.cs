/*Задача 1: Определите, является ли число степенью двойки:
N = 16 -> "Является степень двойки"
N = 12 -> “Не является степенью двойки”*/

int Promt(string massage)
{
    Console.WriteLine(massage);
    int Num = Convert.ToInt32(Console.ReadLine());
    return Num;
}

bool PowerTwo(int a)
{
    if (a == 2)
        return true;
    else if (a % 2 == 0)
        return PowerTwo(a / 2);
    else return false;
}

int Num = Promt($"Введите число  N  ");
if (PowerTwo(Num)) Console.WriteLine($"Явдяется степенью двойки");
else Console.WriteLine($"Не является степенью двойки");