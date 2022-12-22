int N;
int index = 2;
Console.Write("Введите число ");
int.TryParse(Console.ReadLine(), out N);
while(index <= N )
{
    Console.Write($"{index} \n");
    index = index + 2;
}