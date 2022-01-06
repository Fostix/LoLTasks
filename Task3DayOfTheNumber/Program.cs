// По заданному номеру дня недели вывести его название.

Console.Write("Enter number day: ");
int number = int.Parse(Console.ReadLine());

string[] array = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
number = number - 1;

if (number >= 0 & number < 31)
{
    while (number > 6)
    {
        number = number - 7;
    }
    if (number < 6)
    {
        Console.Write(array[number]);
    }
}
else
{
    Console.WriteLine("Incorrect number day");
}
