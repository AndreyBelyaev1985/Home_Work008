// Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования


            
            int[] RandArray(int Length)
    {
        int[] answer = new int[Length];
         for (int i = 0; i < Length; i++)
          {
              answer[i] = new Random().Next(-100, 100);
          }
        return answer;

    }
            
            void PrintArray(int[] Mas)
{
    int count = Mas.Length;
     Console.Write("[");
        
        for (int pos = 0; pos < count; pos++)
        {
            System.Console.Write(Mas[pos] + " ,");
        }
     Console.Write("]");
    
    System.Console.WriteLine();
}

int[] arr = RandArray(5);
int[] arr2 = RandArray(arr.Length); 

for (int i = 0; i < arr.Length; i++)
{

    arr[i] = arr2[i];
}


PrintArray(arr);
PrintArray(arr2);
