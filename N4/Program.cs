Console.WriteLine("Введите целое число");
int a = Convert.ToInt32(Console.ReadLine());
int b = 1;
while (b <= a)
{
    int c = b % 2;
    if (c == 0)
    {
        Console.Write($"{b} ");
    }
    b++;
}
