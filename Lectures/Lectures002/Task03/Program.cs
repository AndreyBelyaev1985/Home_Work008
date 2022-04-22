int [] array = {1,2,3,88,5,6,7,88};
int n = array.Length;
int finde = 88;
int index= 0;

while(index<n)
{
    if(array[index]==finde)
    {
        System.Console.WriteLine(index);
        break;
    }
    index++;
}
