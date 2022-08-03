// Принимает 2 точки и находит расстояние между ними в 2Д
Console.WriteLine("Напишите первые координаты");

double x1 = double.Parse(Console.ReadLine());
double y1 = double.Parse(Console.ReadLine());
Console.WriteLine("Напишите вторые координаты");
double x2 = double.Parse(Console.ReadLine());
double y2 = double.Parse(Console.ReadLine());

double SQUARE( double num1, double num2)
{
    double sum = num1 - num2;
    double sqr = sum*sum;


    return sqr;
}
double a1 = SQUARE(x1,x2);
double a2 = SQUARE(y1,y2);

//Console.WriteLine($"num1 = {a1}, num2 = {a2}");
//double answer = Math.Sqrt(a1 + a2);

Console.WriteLine(Math.Sqrt(a1 + a2));