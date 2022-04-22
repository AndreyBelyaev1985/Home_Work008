/*Напишите программу, которая принимает 
на вход трёхзначное число и на выходе 
показывает последнюю цифру этого числа.*/

System.Console.WriteLine($"Введите трёхзначное число:  ");
int num1 = Convert.ToInt32(Console.ReadLine());
{
    if (num1 > 999) System.Console.Write("ERROR");
    else Console.WriteLine($" Последняя цифра числа: {num1 % 10}");
}

