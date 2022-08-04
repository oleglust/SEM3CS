// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.WriteLine("Введите пятизначное число(например 12345):");
int num = int.Parse(Console.ReadLine());

string numText = Convert.ToString(num);
// переводим число в строку(морно сразу прописать стринг, без парсинга)
void Palindromcheck(string number)
{
  if (number[0]==number[4] || number[1]==number[3])
  {
    Console.WriteLine($"Указанное число палиндром.");
  }
  else Console.WriteLine($"Указанное число не палиндром.");
}

if (numText.Length == 5)
{
  Palindromcheck(numText);
}
else Console.WriteLine("Число не пятизначное");