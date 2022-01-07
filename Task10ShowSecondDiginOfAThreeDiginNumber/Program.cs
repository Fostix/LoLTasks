// Показать вторую цифру трёхзначного числа.

Console.Write("Enter three-digin number: ");
int number = int.Parse(Console.ReadLine());


if (number < 11 & number > -10)
{
    number = new Random().Next(100, 1000);
    Console.WriteLine("You enter number less than 10, i write without you random number: " + number);
}
if (number > 1000 | number < -100)
{
    Console.WriteLine("You enter incorrect number, i correct itself");
}
if (number < 0)
{
    number = number * (-1);
}

if (number < 100)
{
    number = number * 10;
    Console.WriteLine("You enter not three-digin number i add zero: " + number);
}
while (number > 100)
{
    number = number / 10;
}
number = number % 10;
Console.WriteLine(number);