using Green;
Console.OutputEncoding = System.Text.Encoding.Unicode;
Console.InputEncoding = System.Text.Encoding.Unicode;
Console.Write("Nhập số lượng điểm: n = ");
int n = 0;
while (!int.TryParse(Console.ReadLine(), out n))
{
    Console.Write("Bạn nhập sai - thử lại: n = ");
}
List<Points.Point> points = new List<Points.Point>();
points = Points.List_Points(n);
Points.Show_Points(points);
Points.The2furthestpoints(points);
Console.ReadKey();