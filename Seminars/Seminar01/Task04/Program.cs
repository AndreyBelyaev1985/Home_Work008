// Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

System.Console.WriteLine("Введите первое число: ");
int num = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
if(num > num1)System.Console.WriteLine(num);
if(num < num1) Console.WriteLine(num1);
