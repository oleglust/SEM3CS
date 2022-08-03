//принимает на вход N  и выдает квадраты числа от 1 до N
Console.WriteLine("Введите число");
int x = int.Parse(Console.ReadLine());

for( int i = 1; i <= x; i++)
{
    Console.WriteLine($"{x} x {i}  = {i*x}");
}

