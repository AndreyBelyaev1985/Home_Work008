// Напишите программу, которая будет выдавать название дня недели по заданному номеру.

System.Console.WriteLine("Введите число:  ");
int num = Convert.ToInt16(Console.ReadLine());
switch (num)
{
    case 1: System.Console.WriteLine("Понедельник"); break;
    case 2: System.Console.WriteLine("Вторник"); break;
    case 3: System.Console.WriteLine("Среда"); break;
    case 4: System.Console.WriteLine("Четверг"); break;
    case 5: System.Console.WriteLine("Пятница"); break;
    case 6: System.Console.WriteLine("Суббота"); break;
    case 7: System.Console.WriteLine("Воскресенье"); break;
    default: System.Console.WriteLine("ERROR"); break;

}
Console.ReadKey();
