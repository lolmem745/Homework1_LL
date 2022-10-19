Console.WriteLine("Введите целое число");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Четное ли число? -> ");
int b = a % 2;
if (b == 0)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}