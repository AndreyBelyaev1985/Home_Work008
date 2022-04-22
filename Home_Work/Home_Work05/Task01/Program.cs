// Задача 1: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу,
// которая покажет количество чётных чисел в массиве.
    int[]  RandArray(int Length)
    {
      int[] number = new int[Length];  
        for(int i = 0; i < Length; i++)
        {
            number[i] = new Random().Next(100, 500);
    
        }
        return number;
    }

         void PrintArray(int[] Mas)
{
    int count = Mas.Length;
    {
        for(int i = 0; i < Mas.Length; i++)
        {
            Console.Write(Mas[i]+",");
        
        }
        System.Console.WriteLine(Mas[Mas.Length-1]);     //Чтобы не  было запятой
    }

}

         int EvenNumbers(int[] array)

        {
            int count = 0;
        for(int i = 0; i < array.Length; i++)
        {
            if(array[i] % 2 == 0)
            count++;
        }
        return count;
        } 

int[] array = RandArray(20);
PrintArray(array);
System.Console.WriteLine();
System.Console.WriteLine($"Колличество чётных чисел: " + EvenNumbers(array) );
