/* Напишите программу, которая на вход принимает одно число 
(N), а на выходе показывает все целые числа в промежутке от -N 
до N.
4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 
2 -> " -2, -1, 0, 1, 2"
*/

System.Console.WriteLine("Введите число: N ");
int numA = Convert.ToInt32(Console.ReadLine());
int numB = -numA;
System.Console.Write(numB + ",");
while (numB < numA)
{
    numB++;

    System.Console.Write(numB + " ");
}
