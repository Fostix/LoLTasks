// Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0.

Console.Write("Enter X-axis: ");
int xAxis = int.Parse(Console.ReadLine());
Console.Write("Enter Y-axis: ");
int yAxis = int.Parse(Console.ReadLine());

if (xAxis > 0 && yAxis > 0)
{
    Console.WriteLine("First quarter of the coordinate plane");
}
if (xAxis < 0 && yAxis > 0)
{
    Console.WriteLine("Second quarter of the coordinate plane");
}
if (xAxis < 0 && yAxis < 0)
{
    Console.WriteLine("Third quarter of the coordinate plane");
}
if (xAxis > 0 && yAxis < 0)
{
    Console.WriteLine("Fourth quarter of the coordinate plane");
}