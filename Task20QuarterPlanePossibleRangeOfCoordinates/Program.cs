// Задать номер четверти, показать диапазоны для возможных координат.

Console.Clear();
Console.Write("Enter number: ");
int number = int.Parse(Console.ReadLine());

if (number == 1)
{
    Console.WriteLine("X from 0 to infinity; Y from 0 to infinity");
}
if (number == 2)
{
    Console.WriteLine("X from 0 to - infinity; Y from 0 to infinity");
}
if (number == 3)
{
    Console.WriteLine("X from 0 to -infinity; Y from 0 to -infinity");
}
if (number == 4)
{
    Console.WriteLine("X from 0 to infinity; Y from 0 to -infinity");
}
else
{
    Console.WriteLine("there is no such: " + number + " plane of a quarter");
}