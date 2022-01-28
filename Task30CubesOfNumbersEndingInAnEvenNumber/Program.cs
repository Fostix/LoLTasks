// Показать кубы чисел, заканчивающихся на четную цифру.

Console.Write("Enter number: ");
int finishNumber = int.Parse(Console.ReadLine()),
result,
cube = 3;

for (int i = 0; i < finishNumber; i++)
{
    result = i * i * i;
    if(result % 2 == 0)
    {
        Console.WriteLine( i + "^" + cube + " = " + result);
    }
}

