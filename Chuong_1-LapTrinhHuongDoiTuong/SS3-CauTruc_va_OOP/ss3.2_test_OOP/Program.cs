using Green;
Console.OutputEncoding = System.Text.Encoding.Unicode;
Console.InputEncoding = System.Text.Encoding.Unicode;
Console.Write("Nhập số lượng điểm: n = ");
int n = Class_Collection.Int_Input("nhập sai, thử lại: n = ");
while (n < 2)
{
    Console.Write("nhập sai, thử lại: n = ");
    n = Class_Collection.Int_Input("nhập sai, thử lại: n = ");
}
List<Points.Point> points = new List<Points.Point>();
points = Points.List_Points(n);
Points.Show_Points(points);
Points.The2furthestpoints(points);
Console.ReadKey();