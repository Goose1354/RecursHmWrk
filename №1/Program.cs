Console.WriteLine("Введите значение M:");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите значение N:");
int n = int.Parse(Console.ReadLine());
PrintNaturalNumbers(m, n);
Console.ReadLine();

static void PrintNaturalNumbers(int m, int n)
{
    if (m <= n)
    {
        Console.WriteLine(m);
        PrintNaturalNumbers(m + 1, n);
    }
}