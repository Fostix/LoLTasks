// Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран.


string forChoice = "Enter 1 if you wont random\n2 for script\n3 for enter yourself\nchoose: ",
forArryaLength = "Enter array length. array cannot be negative number: ";

int maxChoice = 3,
maxArrayLength = 10000,
one = 1;
int[] array = new int[0];


int intChoice = TestNumber(forChoice, maxChoice, one);

if (intChoice == 1)
{
    int arrayLength = TestNumber(forArryaLength, maxArrayLength, one);
    array = RandomMethod(arrayLength);
}
if (intChoice == 2)
{
    array = ScriptMethod();
}
if (intChoice == 3)
{
    int arrayLength = TestNumber(forArryaLength, maxArrayLength, one);
    array = EnterYourselfMethod(arrayLength, one);
}

PrintArray(array);



int TestNumber(string printText, int maxNumber, int minNumber)
{
    int notNeedToLower = -1,
    needToLower = -2;

    do
    {
        if (notNeedToLower == -2)
        {
            Console.Write(printText.ToLower());
        }
        else
        {
            Console.Write(printText);
        }
        string stringNumber = Console.ReadLine();
        try
        {

            notNeedToLower = Convert.ToInt32(stringNumber);
        }
        catch (System.Exception)
        {

            Console.Write("incorrect please ");
            needToLower = -2;
        }
    } while (notNeedToLower > maxNumber || notNeedToLower < minNumber);


    return notNeedToLower;
}


int[] RandomMethod(int arrayLength)
{
    int[] array = new int[arrayLength];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 2);
    }
    return array;
}



int[] ScriptMethod()
{
    int[] skriptArray = { 1, 0, 0, 0, 0, 0, 1, 1, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, };
    return skriptArray;

}



int[] EnterYourselfMethod(int arrayLength, int one)
{
    string enterText = "Enter zero - 0, or 1: ";

    int[] array = new int[arrayLength];
    int zero = 0;
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = TestNumber(enterText, one, zero);


    }
    return array;
}


void PrintArray(int[] print)
{
    for (int i = 0; i < print.Length; i++)
    {
        Console.Write(print[i] + " ");
    }
}


