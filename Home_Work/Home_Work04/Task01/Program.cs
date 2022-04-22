// Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


            /* ВАРИАНТ 1 - ЧЕРЕЗ МАТЕМАТИЧЕСКУЮ ФУНКЦИЮ

            int Prompt(string massage)
{
    Console.WriteLine(massage);
    string strValue = Console.ReadLine();
    int Value = int.Parse(strValue);
    return Value;

}

int num1 = Prompt("Введите первое число: ");

int num2 = Prompt("Введите второе число: ");

System.Console.WriteLine(Math.Pow(num1, num2));

*/


            // ВАРИАНТ 2 - ЧЕРЕЗ ЦИКЛ


int number1, number2;

System.Console.Write("Введите первое число: ");
number1 = Int32.Parse(Console.ReadLine());

System.Console.Write("Введите второе число: ");
number2 = Convert.ToInt32(Console.ReadLine());

    int pow = 1;

    for (int i = 0; i < number2; i++)
    {
        pow = number1 * pow;
    }

System.Console.WriteLine($"Число {number1} возведенное в степень {number2} равно {pow}");
