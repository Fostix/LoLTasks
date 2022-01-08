// Найти третью цифру числа или сообщить, что её нет.

Console.Write("Enter number: ");
int number = int.Parse(Console.ReadLine());
if (number < 0)
{
    number = number * (-1);
}
while (number > 1000)
{
    number = number / 10;
}
if (number > 99)
{
    Console.WriteLine(number % 10);
}
else
{
    Console.WriteLine("no third digit");
}