/*Напишите программу, которая выводит 
случайное число из отрезка [10, 99] и показывает 
наибольшую цифру числа.
78 -> 8 
12-> 2 
85 -> 8*/

Random rnd = new Random();
int value = rnd.Next(10, 99);
System.Console.WriteLine(value);
int A = value % 10;
int B = value / 10;
if (A > B) System.Console.WriteLine($"Большее число => {A}");
if (B > A) System.Console.WriteLine($"Большее число => {B}");
else if (A == B) System.Console.WriteLine($"Числа равны");
