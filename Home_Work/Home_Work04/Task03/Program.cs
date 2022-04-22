// Задача 3: Напишите программу, которая задаёт массив из 8 элементов случайными числами и выводит их на экран.
// Оформите заполнение массива и вывод в виде функции (пригодится в следующих задачах)



   int Prompt(string massage)
{
    Console.WriteLine(massage);
    string strValue = Console.ReadLine();
    int Value = int.Parse(strValue);
    return Value;

}

            void Rand(int[] Set)
    {
        int lenght = Set.Length;
         for (int i = 0; i < lenght; i++)
          {
              Set[i] = new Random().Next(-9, 10);
          }
       
    }

            void console(int[] Mas)
{
    int count = Mas.Length;
        for (int pos = 0; pos < count; pos++)
            {
                Console.Write(Mas[pos] + " ,");
            }   
}

int number = Prompt("Задайте длину массива: ");
int[] array = new int[number];

Rand(array);
console(array);
