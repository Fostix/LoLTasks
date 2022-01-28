// Задать массив из 8 элементов и вывести их на экран.

Console.Write("Enter 1 If you want to enter the elements of an array or 2 already harvested array: ");
int number = int.Parse(Console.ReadLine()),
arrayLength = 8;

if (number == 1)
{
    string[] array = new string[arrayLength];
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(i + 1 + " enter word: ");
        array[i] = Console.ReadLine();
    }
    PrintMethod(array);
}
else if (number == 2)
{
    string[] array = { "hello mr boomber", "hello world", "how much many do you need", "bingly bong", "something", "hello war", "num23bers6", "09384375987209348759087634587673459876345987634589763498765348976" };
    PrintMethod(array);
}
else
{
    Console.WriteLine("incorrect number");
}
void PrintMethod(string[] print)
{
    for (int i = 0; i < print.Length; i++)
    {
        Console.WriteLine($"index element:[{i}] = {print[i]}");

    }
}