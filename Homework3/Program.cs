// Программа принимает число и создает таблицу кубов чисел от 1 до этого числа
Console.WriteLine("Введите число:");
int x = int.Parse(Console.ReadLine());

for( int i = 1; i <= x; i++)
{
    Console.WriteLine($"{i} в кубе   = {i*i*i}");
}