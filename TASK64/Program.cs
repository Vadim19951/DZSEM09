int n = InputInt("Enter number N: ");
int m = InputInt("Enter number M: ");
Console.WriteLine("The train of numbers lower!)"); 
Console.WriteLine(NaturalNumber(n,m));
int NaturalNumber(int n, int m)

{   if(n < m)
{
    int temp = n;
    n = m;
    m = temp;
}
    if (n == m)
    {
        return m;
    }
    else
    {
        Console.Write(NaturalNumber(n - 1, m) + " ");
        return n;
    }
}
int InputInt(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}