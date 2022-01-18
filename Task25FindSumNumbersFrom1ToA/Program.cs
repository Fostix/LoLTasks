// Найти сумму чисел от 1 до А.

Console.Write("Enter number: ");
int number = int.Parse(Console.ReadLine());

for (int i = number - 1; i >= 1; i--)
{
    number += i;
}

Console.WriteLine(number);