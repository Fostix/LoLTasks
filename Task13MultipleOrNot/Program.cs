// Выяснитть, кратно ли число заданному, если нет , вывести остаток.

Console.Write("Enter dividend: ");
int dividend = int.Parse(Console.ReadLine());
Console.Write("Enter divisor: ");
int divisor = int.Parse(Console.ReadLine()),
remainder = dividend % divisor,
quotient = dividend / divisor;

if (0 == remainder)
{
    Console.WriteLine(quotient + " quotient");
}
else
{
    Console.WriteLine(remainder + " remainder");
}