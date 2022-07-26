
int x = 0;
Console.WriteLine("Введите число");
x = int.Parse(Console.ReadLine());

if (x > 99)
{
   Console.WriteLine(x.ToString()[2]);
}
else 
Console.WriteLine("Третьей цифры нет");