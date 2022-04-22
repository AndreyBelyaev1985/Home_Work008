System.Console.WriteLine($"Введите число  ");
string A = Console.ReadLine();
int[] arr = new int[A.Length];
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = Convert.ToInt32(A.Substring(i, 1));
}
if (arr.Length < 3) System.Console.WriteLine($"Третья цифра отсутствует  ");
else System.Console.WriteLine($"Третья цифра:  " + arr[2]);