/* Напишите программу, которая на вход принимает значение, а 
на выходе показывает обратное значение.
1 -> 1 
2 -> 0.5
0.25 -> 4*/

System.Console.WriteLine("Введите число: ");
double numberA = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine(1 / numberA);
