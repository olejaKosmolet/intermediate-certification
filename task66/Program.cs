int PrintNumber(int M, int N)
{
    int sum = 0;
    if (M == N)
        return sum + N;
    else
        sum += M;
    return  PrintNumber(M + 1, N) + sum;
}

Console.Clear();
Console.Write("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(PrintNumber(M, N));