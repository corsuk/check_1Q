void ThreeSymbols (string [] array)
{ 
    int count = 0;
    string [] arr = new string [array.Length];
    for (int i = 0; i < array.Length-1; i++)
    {
        if (array[i].Length <= 3)
        {
            arr[count] =array[i];
            count++;
        }
    }
    PrintArr(arr, count);
}
void PrintArr (string [] arr, int count)
{
    for ( int i = 0; i < count; i++)
    {
        Console.Write(arr[i]+ ", ");
    }
}

string [] array1 = {"1234", "1567", "-2", "computer science"};
Console.WriteLine(string.Join("; ", array1));
ThreeSymbols(array1);
