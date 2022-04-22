/*Задача 3: Напишите программу, которая выводит третью 
цифру заданного числа или сообщает, что третьей цифры 
нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6*/

System.Console.WriteLine($"Введите число => ");
string A = Console.ReadLine();
int[] array = new int[A.Length];
for (int i = 0; i < A.Length; i++)
{
    array[i] = Convert.ToInt32(A.Substring(i, 1));
}
if (array.Length < 3) System.Console.WriteLine($"Третья цифра отсутствует");
else System.Console.WriteLine($"Третья цифра  " + array[2]);
/*
// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Write("Введите число => ");
string A = Console.ReadLine();
int[] arr = new int[A.Length];
for (int i = 0; i < A.Length; i++)
{
    arr[i] = Convert.ToInt32(A.Substring(i, 1));
}
if (arr.Length < 3) Console.WriteLine("Третьей цифры нет");
else Console.WriteLine($"Третья цифра заданного числа => {arr[2]}");




*/


//if(number < 100) System.Console.WriteLine($"Третья цифра отсутствует");
//else Console.WriteLine($"{number %10}");
