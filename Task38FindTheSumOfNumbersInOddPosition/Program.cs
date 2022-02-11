// Найти сумму чисел одномерного массива стоящих на нечетной позиции.


int maxLength = 1000000,
minLength = 1,
length = 0;


do
{
    Console.Write("Enter array length: ");
    string strLength = Console.ReadLine();
    try
    {
        length = Convert.ToInt32(strLength);
    }
    catch (System.Exception)
    {
        Console.Write("Enter only natural number: ");
    }
} while (length < minLength || length > maxLength);

int[] array = new int[length];

FillArray(array);
FindSum(array);
PrintArray(array);


void FillArray(int[] fill)
{
    for (int i = 0; i < fill.Length; i++)
    {
        fill[i] = new Random().Next(0, 100);
    }
}


void FindSum(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i+=2)
    {
        sum+=array[i];
    }
    Console.WriteLine(sum);
}


void PrintArray(int[] print)
{
    for (int i = 0; i < print.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}