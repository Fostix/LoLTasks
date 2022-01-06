// Выяснить является ли число чётным.

Console.Write("Enter number: ");
int number = int.Parse(Console.ReadLine());

if (0 == number % 2)
{
    Console.WriteLine(number + " even number.");
}
else
{
    Console.WriteLine(number + " not even number.");
}