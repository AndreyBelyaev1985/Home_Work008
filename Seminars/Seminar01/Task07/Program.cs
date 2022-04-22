/* Напишите программу вычисления модуля числа.
2 -> 2
-3 -> 3
-7 -> 7 */

System.Console.WriteLine("Введите число модуля:  ");
int numA = Convert.ToInt32(Console.ReadLine());
if (numA < 0) Console.Write(-numA);
else Console.WriteLine(numA);

