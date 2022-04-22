// Задача 2. Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
//y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


            float Prompt(string massege)
{
Console.Write(massege);
string strValue = Console.ReadLine();
float Value = float.Parse(strValue);
return Value;

}

float b1 = Prompt("Введите число b1 => ");
float k1 = Prompt("Введите число k1 => ");
float b2 = Prompt("Введите число b2 => ");
float k2 = Prompt("Введите число k2 => ");

float x;
float y;

x = (b2 - b1) / (k1 - k2);  
y = k1 * x + b1;

System.Console.WriteLine($"Координаты точки М пересечения двух прямых ({x}; {y}) ");
