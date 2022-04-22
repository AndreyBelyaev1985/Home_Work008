// Задача 3: // Задача 3: 
//Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
// [3, 7, 22, 2, 78] -> 76



        double[] RandArray(int Set)   // Создание рандомного вещественного массива в пределах(от и до)
{
    double[] answer = new double[Set];
    for (int i = 0; i < Set; i++)
    {
        answer[i] = new Random().NextDouble() * 100;
        
    }
    return answer;
}


        void PrintArray(double[] Mas) // Вывод одномерного массива
{
    double count = Mas.Length;
        for (int pos = 0; pos < count; pos++)
            {
                string value = string.Format ("{0:0.000}", Mas[pos]);
        Console.Write($"{value} || ");
               
            }
    
}


        double MinValue (double[] array)
{
    double minValue = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (minValue > array[i])
        minValue = array[i];
        //string value = string.Format ("{0:0.000}", minValue);
    }
    return minValue;
} 


        double MaxValue (double[] array)
{
    double maxValue = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (maxValue < array[i])
        maxValue = array[i];
    }
    return maxValue;
} 


double[] arr = RandArray(6);
PrintArray(arr);

double DifferenceValue = MaxValue(arr) - MinValue(arr);
string PrintMinValue = string.Format ("{0:0.000}", MinValue(arr));
string PrintMaxValue = string.Format ("{0:0.000}", MaxValue(arr));
string PrintDifferenceValue = string.Format ("{0:0.000}", DifferenceValue);
System.Console.WriteLine();
System.Console.WriteLine();
Console.WriteLine($"Разница между максимальным {PrintMaxValue} и минимальным {PrintMinValue} элементом массива равна  " + PrintDifferenceValue);



/*
//Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
// [3, 7, 22, 2, 78] -> 76



        double[] RandArray(int Set)   // Создание рандомного вещественного массива в пределах(от и до)
{
    double[] answer = new double[Set];
    for (int i = 0; i < Set; i++)
    {
        answer[i] = new Random().NextDouble() * 100;
        
    }
    return answer;
}


        void PrintArray(double[] Mas) // Вывод одномерного массива
{
    double count = Mas.Length;
        for (int pos = 0; pos < count; pos++)
            {
                string value = string.Format ("{0:0.000}", Mas[pos]);
        Console.Write($"{value} || ");
               
            }
    
}


        double MinValue (double[] array)
{
    double minValue = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (minValue > array[i])
        minValue = array[i];
        //string value = string.Format ("{0:0.000}", minValue);
    }
    return minValue;
} 


        double MaxValue (double[] array)
{
    double maxValue = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (maxValue < array[i])
        maxValue = array[i];
    }
    return maxValue;
} 


double[] arr = RandArray(6);
PrintArray(arr);

double DifferenceValue = MaxValue(arr) - MinValue(arr);
string PrintMinValue = string.Format ("{0:0.000}", MinValue(arr));
string PrintMaxValue = string.Format ("{0:0.000}", MaxValue(arr));
string PrintDifferenceValue = string.Format ("{0:0.000}", DifferenceValue);
System.Console.WriteLine();
System.Console.WriteLine();
Console.WriteLine($"Разница между максимальным {PrintMaxValue} и минимальным {PrintMinValue} элементом массива равна  " + PrintDifferenceValue);
*/