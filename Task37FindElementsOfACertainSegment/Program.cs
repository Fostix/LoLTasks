// В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99].

int[] array = new int[123];
FillArray(array);
FindElements(array);
PrintArray(array);


void FillArray(int[] fill)
{
    for (int i = 0; i < fill.Length; i++)
    {
        fill[i] = new Random().Next(0, 300);
    }
}


void FindElements(int[] find)
{
    int many = 0,
    segmentFrom = 10,
    segmentTo = 100;
    for (int i = 0; i < find.Length; i++)
    {
        if (find[i] >= segmentFrom && find[i] < segmentTo)
        {
            many++;
        }
    }
    Console.WriteLine(many + " elements in array this diapason (10, 99)");

}

void PrintArray(int[] print)
{
    for (int i = 0; i < print.Length; i++)
    {
        Console.Write(print[i] + " ");
    }
}