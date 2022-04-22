// Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1
// Если N = 5->01123
// Если N = 3->011
// Если N = 7->0112358

            int Prompt(string massege)
{
Console.Write(massege);
int Value = Convert.ToInt32(Console.ReadLine());
return Value;

}

int n = Prompt("Введите число n  ");


int n1 = 0;
int n2 = 1;
int n3; //= n1 +n2;
int i = 0;
System.Console.Write(n1 + " " + n2 + " ");

while(i<n-2)
{
n3 = n1 + n2;
n1 = n2;
n2 = n3;
i++;

System.Console.Write(n2 + " ");
}
