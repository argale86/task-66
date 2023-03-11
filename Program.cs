//задайте число M и N и найдите сумму натуральных чисел между ними с помощью рекурсии

double Vivod (uint m, uint n, double summn)
{
    if (m <= n) 
    {
    summn = m + Vivod (m+1,n,summn);
    }
    return summn;
}

Console.WriteLine("Введите целое положительное число M:");
uint numberm = Convert.ToUInt32(Console.ReadLine());
Console.WriteLine("Введите целое положительное число N:");
uint numbern = Convert.ToUInt32 (Console.ReadLine());
double sum = 0;
Console.WriteLine(Vivod (numberm,numbern,sum));

