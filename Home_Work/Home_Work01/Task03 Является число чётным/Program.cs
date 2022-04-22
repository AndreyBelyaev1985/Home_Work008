//Задача 3: Напишите программу, которая на вход принимает число и выдаёт,
 //является ли число чётным (делится ли оно на два без остатка).

System.Console.WriteLine("Введите число:  ");
int numA = Convert.ToInt32(Console.ReadLine());

if(numA % 2 ==0) System.Console.WriteLine("Число четное");
else System.Console.WriteLine("Введено не чётное число ");
