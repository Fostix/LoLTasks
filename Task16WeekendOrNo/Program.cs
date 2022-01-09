// Дано число обозначающее день недели. Выяснить является номер дня недели выходным.

Console.Write("Enter number day: ");
int numberDay = int.Parse(Console.ReadLine());
string[] array = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
numberDay--;
if (numberDay > -1 && numberDay < 31)
{
    while (numberDay > 6)
    {
        numberDay -= 7;
    }
    if (numberDay > 4)
    {
        Console.Write("Weekend: " + array[numberDay]);
    }
    else
    {
        Console.WriteLine("Workweek: " + array[numberDay]);
    }
}
else
{
    Console.WriteLine("Incorrect day");
}