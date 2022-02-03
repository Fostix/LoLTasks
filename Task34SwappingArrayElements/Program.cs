// Написать программу замену элементов массива на противоположные.
Console.Write("Enter array length: ");
int arrayLength = int.Parse(Console.ReadLine());
int[] array = new int[arrayLength];

ArrayRandomFillMethod(array);
PrintArray(array);
Console.WriteLine();
SwapArrayMethod(array);
PrintArray(array);


void ArrayRandomFillMethod(int[] fill)
{
    for (int i = 0; i < fill.Length; i++)
    {
        fill[i] = new Random().Next(-9, 10);
    }
}


void SwapArrayMethod(int[] swap)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = -array[i];
    }
}



void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}