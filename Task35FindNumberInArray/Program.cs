// Определить, присутствует ли в заданном массиве, некоторое число.

int maxArrayLength = 10000,
maxDigit = 9;
string writeLength = "Enter array length: ",
writeDigit = "Enter which digit need find in array: ";

int arraLength = TestNumber(maxArrayLength, writeLength);
int[] array = new int[arraLength];
Randomazir(array);
int digit = TestNumber(maxDigit, writeDigit);
LookingForANumberInAnArray(array, digit);
PrintArray(array);


int TestNumber(int maxNumber, string Text)
{
    int number = -1;
    do
    {
        Console.Write(Text);
        string strNumber = Console.ReadLine();
        try
        {
            number = Convert.ToInt32(strNumber);
            if (number < 0)
            {
                Console.WriteLine("Incorrect");
            }
            if (number > maxNumber)
            {
                Console.WriteLine("Incorrect");
            }
        }
        catch (System.Exception)
        {
            Console.WriteLine("Incorrect");
            //        throw;
        }
    } while (number < 0 || number > maxNumber);
    return number;
}


void Randomazir(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 10);
    }
}

void LookingForANumberInAnArray(int[] array, int digit)
{
    int index = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == digit)
        {
            index++;
            Console.WriteLine($"{index} element, index = {i}, number = {digit}.");
        }
    }
}


void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}





