// В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом.

int minLength = 1,
maxLength = 1000000,
length = 0;


do
{
    Console.Write("Enter array length: ");
    string sLength = Console.ReadLine();
    try
    {
        length = Convert.ToInt32(sLength);
    }
    catch (System.Exception)
    {
        Console.WriteLine("Incorrect");
    }
} while (length < minLength || length > maxLength);

double[] array = new double[length];


FillArray(array);
FindMinAndMax(array);
PrintArray(array);




void FillArray(double[] fill)
{

    for (int i = 0; i < fill.Length; i++)
    {
        fill[i] = new Random().Next(1,10) / 1.7;

    }
}




void FindMinAndMax(double[] array)
{
    double min = array[0],
    max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
        if (array[i] > max)
        {
            max = array[i];
        }
    }
    Console.Write($"min = {min}\nmax = {max}\n");


}



void PrintArray(double[] print)
{
    for (int i = 0; i < print.Length; i++)
    {
        Console.Write(print[i] + " ");
    }
}

