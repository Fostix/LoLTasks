// Дано число. Проверить кратно ли оно 7 и 23.

Console.Write("Enter number: ");
int number = int.Parse(Console.ReadLine()),
mod7 = number % 7,
mod23 = number % 23;
if (0 == mod23)
{
    Console.WriteLine("multiple of 23. equals: " + number / 23);
}
else
{
    Console.WriteLine("no multiple of 23.");
    
}
if (0 == mod7)
{
    Console.WriteLine("multiple of 7. equals: " + number / 7);
}
else
{
    Console.WriteLine("no multiple of 7.");
}