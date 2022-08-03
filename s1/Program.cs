// напишите программу, которая на вход принимает координаты Х и Y, и выдает номер четверти, в которой находится точка
Console.WriteLine("Введите X");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("Введите Y");
int y = int.Parse(Console.ReadLine());

string getPlane( int xLocal, int yLocal)
{
    if(xLocal > 0 && yLocal > 0) return "1";
    if(xLocal < 0 && yLocal > 0) return "2";
    if(xLocal > 0 && yLocal < 0) return "3";
    if(xLocal < 0 && yLocal < 0) return "4";
    return "err";
}

Console.WriteLine(getPlane(x,y));