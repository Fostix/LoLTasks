// Написать программу вычисления произведения чисел от 1 до N.

Console.Write("Enter first factor: ");
int firstFactor = int.Parse(Console.ReadLine());
Console.Write("Enter number: ");
int finish = int.Parse(Console.ReadLine());

for (int i = 1; i < finish; i++)
{
    Console.WriteLine(firstFactor + " * " + i + " = " + firstFactor * i);
}