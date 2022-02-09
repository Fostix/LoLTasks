// Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел.

Console.Write("Enter array length: ");
string textForLength = "Length cannot be negative number. Enter correct please: ",
veryMore = "Number very more. Enter less please: ";
int maxLength = 10000;


int length = TestNumber(textForLength, veryMore, maxLength);
int[] array = new int[length];
FillArray(array);

Console.Write("Choice\n 1 - fill all odd numbers\n 2 - fill all even numbers\n 3 - fill odd and even numbers\nEnter number: ");
string ifNegative = "Enter positive number\nChoice\n 1 - fill all odd numbers\n 2 - fill all even numbers\n 3 - fill odd and even numbers\nEnter number: ",
ifVeryMore = "Choice\n 1 - fill all odd numbers\n 2 - fill all even numbers\n 3 - fill odd and even numbers\nEnter number: ";
int maxChoice = 4,
choice = TestNumber(ifNegative, ifVeryMore, maxChoice);

if (choice == 1)
{
    OddMethod(array);
}
else if (choice == 2)
{
    EvenMethod(array);
}
else if (choice == 3)
{
    OddMethod(array);
    EvenMethod(array);
}



PrintArray(array);


int TestNumber(string text, string maxText, int maxLength)
{
    int intNumber = 0;
    do
    {
        string number = Console.ReadLine();
        try
        {
            intNumber = Convert.ToInt32(number);
            if(intNumber < 0)
            {
                Console.Write(text);
            }
            if (intNumber > maxLength)
            {
                Console.Write(maxText);
            }
        }

        catch (System.Exception)
        {
            Console.WriteLine("Enter only number");
            throw;
        }
    } while (intNumber < 0 || intNumber > maxLength);

    return intNumber;
}




void FillArray(int[] fill)
{
    for (int i = 0; i < fill.Length; i++)
    {
        fill[i] = new Random(). Next(100, 1000);
    }
}




void OddMethod(int[] odd)
{
    int many = 0;
    for (int i = 0; i < odd.Length; i++)
    {
        if(odd[i] % 2 != 0)
        {
            many++;
        }
    }
    Console.WriteLine("Odd number: " + many);
}


void EvenMethod(int[] odd)
{
    int many = 0;
    for (int i = 0; i < odd.Length; i++)
    {
        if(odd[i] % 2 == 0)
        {
            many++;
        }
    }
    Console.WriteLine("Even numbers: " + many);
}













void PrintArray(int[] print)
{
    for (int i = 0; i < print.Length; i++)
    {
        Console.Write(print[i] + " ");
    }
}