void FillArray(int[] collection)
{
    int Length = collection.Length;
    int i = 0;
    while (i < Length)
    {
        collection[i] = new Random().Next(0, 10);
        i++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection,  int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;
    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
        }
        index++;
    }
    return position;
}


int[] array = new int[10];

FillArray(array);
PrintArray(array);
System.Console.WriteLine();
int pos = IndexOf(array, 5);
System.Console.WriteLine(pos);

