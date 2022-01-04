long start = DateTimeOffset.UtcNow.ToUnixTimeSeconds();
int n = 1000000;
double[] x = new double[n];
Random rand = new Random();
for (int i = 0; i < n; i++)
{
    x[i] = rand.NextDouble() * (100 - (-100)) + (-100);
}
// foreach (double value in x)
// {
//     Console.WriteLine("{0:0.000}", value);
// }
Array.Sort(x);
long end_time = DateTimeOffset.UtcNow.ToUnixTimeSeconds() - start;
foreach (double value in x)
{
    Console.WriteLine("{0:0.000}", value);
}
Console.WriteLine(end_time);
Console.WriteLine(DateTimeOffset.UtcNow.ToUnixTimeSeconds() - start);