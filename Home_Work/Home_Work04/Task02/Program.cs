// Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12



    int a, b;

    Console.Write("Введите число: ");
    a = Convert.ToInt32(Console.ReadLine());

    int sum = 0;
        while (a != 0)
        {
            b = a % 10;
            a = a / 10;
            sum = sum + b;
        }

System.Console.WriteLine("Сумма цифр: " + sum);
