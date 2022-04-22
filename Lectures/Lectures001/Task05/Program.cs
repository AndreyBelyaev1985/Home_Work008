System.Console.WriteLine("Введите ваше имя:  ");
string username = Console.ReadLine();

if (username.ToLower() == "маша")
{
    System.Console.WriteLine("УРА, это же МАША!!!");
}
else
{
    Console.Write("Привет,  ");
    Console.WriteLine(username);
}