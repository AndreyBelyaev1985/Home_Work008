/*
Задача 1: Пользователь вводит с клавиатуры М чисел.
Посчитайте, сколько чисел больше 0 ввел пользователь.
0, 7, 8, -2 -> 2
-1, -7, 567, 89, 223 -> 3
*/

 
 int [] a = new int[5];   // Длина массива ограничена [5] элементами
System.Console.Write("Введите M чисел:  ");

int result = 0;

for (int i = 0; i < a.Length; i++)
{
    if (Int32.TryParse(Console.ReadLine(), out a[i]) != true)
    {
        System.Console.WriteLine("Введено не число");
    }
else
    {
        if (a [i] > 0)
        {
            result = result + 1;
        }
    }

}

System.Console.WriteLine($"Количество чисел больше 0 равно " + result);
