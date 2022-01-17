// Найти расстояние между точками в пространстве 2D/3D.
Console.Clear();




void MethodPlane()
{

    Console.Write("Enter Ax: ");
    double Ax = double.Parse(Console.ReadLine());
    Console.Write("Enter Ay: ");
    double Ay = double.Parse(Console.ReadLine());
    Console.Write("Enter Bx: ");
    double Bx = double.Parse(Console.ReadLine());
    Console.Write("Enter By: ");
    double By = double.Parse(Console.ReadLine());

    Console.WriteLine(Math.Sqrt(Math.Pow(Ax - Bx, 2) + Math.Pow(Ay - By, 2)));
}


void MethodSpace()
{
    Console.Write("Enter Ax: ");
    double Ax = double.Parse(Console.ReadLine());
    Console.Write("Enter Ay: ");
    double Ay = double.Parse(Console.ReadLine());
    Console.Write("Enter Az: ");
    double Az = double.Parse(Console.ReadLine());
    Console.Write("Enter Bx: ");
    double Bx = double.Parse(Console.ReadLine());
    Console.Write("Enter By: ");
    double By = double.Parse(Console.ReadLine());
    Console.Write("Enter Bz: ");
    double Bz = double.Parse(Console.ReadLine());

    Console.WriteLine(Math.Sqrt(Math.Pow(Ax - Bx, 2) + Math.Pow(Ay - By, 2) + Math.Pow(Az - Bz, 2)));
}




Console.Write("click 1 for plane or 2 for space: ");
int number = int.Parse(Console.ReadLine());

if (1 == number)
{
    MethodPlane();
}
else if(2 == number)
{
    MethodSpace();
}
else
{
    Console.WriteLine("incorrect number entered");

}





