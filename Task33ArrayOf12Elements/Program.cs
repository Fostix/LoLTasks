// Задать массив из 12 элементов, заполненных числами из [0,9]. Найти сумму положительных/отрицательных элементов массива.

int[] array = new int[12];
int positiveNumber = 0,
negativeNumber = 0,
zero = 0;

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0,10);
}


for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0)
    {
        positiveNumber += array[i];
    }
    else if (array[i] < 0)
    {
        negativeNumber += array[i];
    }
    else
    {
        zero++;
    }
}


Console.Write($"Sum positive number = {positiveNumber}\nSum negative number = {negativeNumber}\nHow many zeros = {zero}\n");

//PrintArray(array);

void PrintArray(int[] print)
{
    for (int i = 0; i < print.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}