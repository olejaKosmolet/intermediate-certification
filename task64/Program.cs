string PrintNumber(int N)
{
if (N == 1)
    return "1";
return $"{N} " + PrintNumber(N - 1);
}

Console.Clear();
Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(PrintNumber(N));