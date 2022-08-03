// Напишите программу, которая по заданной четверти дает диапазон возможных координат х и у
Console.WriteLine("Введите номер четверти:");
int q = int.Parse(Console.ReadLine());
string getDIAPAZONE( int qLocal)
{
    if(qLocal == 1 ) return "X>0;Y>0";
    if(qLocal == 2 ) return "X<0;Y>0";
    if(qLocal == 3 ) return "X>0;Y<0";
    if(qLocal == 4 ) return "X<0;Y<0";
    return "err";
}

Console.WriteLine(getDIAPAZONE(q));