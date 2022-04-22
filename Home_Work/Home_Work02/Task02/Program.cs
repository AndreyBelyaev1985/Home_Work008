/*Задача 2: Напишите программу, которая выводит 
случайное трёхзначное число и удаляет вторую цифру 
этого числа.
456 -> 46
782 -> 72
918 -> 98*/

Random rnd = new Random();
int value = rnd.Next(100, 999);
System.Console.WriteLine(value);
Console.WriteLine($"{value / 100}{value % 10} ");
