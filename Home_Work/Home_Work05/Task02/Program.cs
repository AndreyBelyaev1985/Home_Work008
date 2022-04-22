//Задача 2: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

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
        System.Console.WriteLine(Mas[Mas.Length-1]); 
    }    
}

 int SummaElements(int[] array)

        {
            int sum = 0;
        for(int i = 0; i < array.Length; i++)
        {
            if(i % 2 != 0)
            sum += array[i];
        }
        return sum;
        } 






int[] array = RandArray(20);
PrintArray(array);
System.Console.WriteLine();
System.Console.WriteLine($"Сумма элементов на нечётных позициях: " + SummaElements(array));
