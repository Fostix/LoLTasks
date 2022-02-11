// Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.

int maxLength = 1000000,
minLength = 0,
length = -1;


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
        Console.Write("Incorrect ");
    }

} while (length < minLength || length > maxLength);

int[] array = new int[length];

FillArray(array);
ProductOfPairs(array);
PrintArray(array);




void FillArray(int[] fill)
{
    for (int i = 0; i < fill.Length; i++)
    {
        array[i] = new Random().Next(1, 10);
    }
}




void ProductOfPairs(int[] array)
{
    int length = array.Length / 2,
    j = 0;
    for (int i = array.Length - 1; i >= length; i--)
    {
        if (j == i)
        {
            break;
        }
        Console.WriteLine($"{array[j]} * {array[i]} = {array[j] * array[i]}");
        j++;
    }
}




void PrintArray(int[] print)
{
    for (int i = 0; i < print.Length; i++)
    {
        Console.Write(print[i] + " ");
    }
}