long start = DateTimeOffset.UtcNow.ToUnixTimeSeconds();
int n = 1000000000;
List<double> x = new List<double>();
Random rand = new Random();
for (int i = 0; i < n; i++)
{
    x.Add(rand.NextDouble() * (100 - (-100)) + (-100));
}
x.Sort();
long end_time = DateTimeOffset.UtcNow.ToUnixTimeSeconds() - start;
// foreach (double value in x)
// {
//     Console.WriteLine("{0:0.000}", value);
// }
Console.WriteLine(end_time);
Console.WriteLine(DateTimeOffset.UtcNow.ToUnixTimeSeconds() - start);