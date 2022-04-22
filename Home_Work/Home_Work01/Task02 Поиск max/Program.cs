//Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

System.Console.WriteLine("Введите первое число:  ");
int numA = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второе число:  ");
int numB = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите третье число:  ");
int numC = Convert.ToInt32(Console.ReadLine());
int max = numA;

if (numB > max) max = numB;
if (numC > max) max = numC;
System.Console.WriteLine($"Максимальное число: {max} ");
