int a;
Console.Write("Введите число ");
int.TryParse(Console.ReadLine(), out a);
int b = a % 2;
if(b == 0)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}
