﻿/*Задача 1: Напишите программу, которая принимает на 
вход трёхзначное число и на выходе показывает вторую 
цифру этого числа.*/

System.Console.WriteLine($"Введите трёхзначное число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Вторая цифра числа" + num1 / 10 % 10);