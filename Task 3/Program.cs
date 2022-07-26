int number = 0;

Console.WriteLine("Введите цифру обозначающую день недели");
number = int.Parse(Console.ReadLine());

if (number>=6 && number<=7)
{
    Console.WriteLine($"{number}-> Да");
}
else
Console.WriteLine($"{number}-> Нет");
