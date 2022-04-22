// Напишите программу которая на вход принимает два числа и проверяет является ли первое число квадратом второго.

System.Console.WriteLine("Введите число:  ");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второе число:  ");
int b = Convert.ToInt32(Console.ReadLine());
if (b == a * a) System.Console.WriteLine("Квадрат числа равен:  " + a * a);
else System.Console.WriteLine("Введенное число не квадрат второго числа:  ");
