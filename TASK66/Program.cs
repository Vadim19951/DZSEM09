int n = InputInt("Enter number N: ");
int m = InputInt("Enter number M: ");
Console.WriteLine($"We have SUM: {SumNumber(n, m)}");
int SumNumber(int n, int m)
{
    
    int sum = n;
    if (n == m)
    {
        return sum;
    }
    else
    {
        return sum + SumNumber(n+1, m);
    }

}
int InputInt(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}

