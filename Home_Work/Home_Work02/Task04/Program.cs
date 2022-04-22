/*Задача 4: Напишите программу, которая принимает на 
вход цифру, обозначающую день недели, и проверяет, 
является ли этот день выходным.
6 -> да 
7 -> да 
1 -> нет*/

System.Console.WriteLine("Введите цифру:  ");
int num = Convert.ToInt16(Console.ReadLine());
switch (num)
{
    case 1: System.Console.WriteLine("Нет"); break;
    case 2: System.Console.WriteLine("Нет"); break;
    case 3: System.Console.WriteLine("Нет"); break;
    case 4: System.Console.WriteLine("Нет"); break;
    case 5: System.Console.WriteLine("Нет"); break;
    case 6: System.Console.WriteLine("Да выходной"); break;
    case 7: System.Console.WriteLine("Да выходной"); break;
    default: System.Console.WriteLine("ERROR"); break;

}
Console.ReadKey();
