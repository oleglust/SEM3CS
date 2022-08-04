// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
Console.WriteLine("Напишите первые координаты");

double x1 = double.Parse(Console.ReadLine());
double y1 = double.Parse(Console.ReadLine());
double z1 = double.Parse(Console.ReadLine());
Console.WriteLine("Напишите вторые координаты");
double x2 = double.Parse(Console.ReadLine());
double y2 = double.Parse(Console.ReadLine());
double z2 = double.Parse(Console.ReadLine());
double SQUARE( double num1, double num2)
{
    double sum = num1 - num2;
    double sqr = sum*sum;


    return sqr;
}
double a1 = SQUARE(x1,x2);
double a2 = SQUARE(y1,y2);
double a3 = SQUARE(z1,z2);


Console.WriteLine(Math.Sqrt(a1 + a2 + a3));
