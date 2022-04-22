//Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

System.Console.WriteLine("Введите первое число:  ");
int numA = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второе число:  ");
int numB = Convert.ToInt32(Console.ReadLine());

if (numA > numB) System.Console.WriteLine($"Большее число: {numA}, меньшее число {numB}");

if (numA < numB) System.Console.WriteLine($"Большее число: {numB}, меньшее число {numA}");

