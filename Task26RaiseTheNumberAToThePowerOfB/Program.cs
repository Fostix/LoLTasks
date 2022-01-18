// Возведите число А в натуральную степень B используя цикл.

Console.Write("Enter number: ");
ulong number = ulong.Parse(Console.ReadLine());
Console.Write("Enter power: ");
ulong power = ulong.Parse(Console.ReadLine()),
saveNumber = number;

while (power > 1)
{
    number *= saveNumber;
    power--;
}
Console.WriteLine(number);