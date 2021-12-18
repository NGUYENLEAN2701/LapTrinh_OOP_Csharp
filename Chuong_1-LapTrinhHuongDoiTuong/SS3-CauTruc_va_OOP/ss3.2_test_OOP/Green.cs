namespace Green
{
    public class Points
    {
        public struct Point
        {
            public float x;
            public float y;
            public Point(float x, float y)
            {
                this.x = x;
                this.y = y;
            }
        }
        public static List<Point> List_Points(int n)
        {
            List<Point> points = new List<Point>();
            Console.WriteLine("1 - Nhập Dữ Liệu Tự Động");
            Console.WriteLine("2 - Nhập Tay Dữ Liệu");
            Console.Write("-> Chọn: ");
            int ch = 1;
            while (!int.TryParse(Console.ReadLine(), out ch))
            {
                Console.Write("Bạn nhập sai - thử chọn lại: ");
            }
            if (ch == 2)
            {
                for (int i = 0; i < n; i++)
                {
                    Point p = new Point(0, 0);
                    Console.WriteLine("Điểm {0} :", i + 1);
                    Console.Write("-> x = ");
                    while (!float.TryParse(Console.ReadLine(), out p.x))
                    {
                        Console.Write("Bạn nhập sai - thử lại: x = ");
                    }
                    Console.Write("-> y = ");
                    while (!float.TryParse(Console.ReadLine(), out p.y))
                    {
                        Console.Write("Bạn nhập sai - thử lại: y = ");
                    }
                    points.Add(p);
                }
            }
            else
            {
                Random rand = new Random();
                for (int i = 0; i < n; i++)
                {
                    Point p = new Point((float)rand.Next(-10000, 10000) / 100, (float)rand.Next(-10000, 10000) / 100);
                    points.Add(p);
                }
            }
            return points;
        }
        public static void Show_Points(List<Point> p)
        {
            foreach (var (item, index) in p.Select((item, index) => (item, index)))
            {
                Console.WriteLine("p{0}({1:0.00}, {2:0.00})", index + 1, item.x, item.y);
            }
        }
        public static float Distance_2_Points(Point p1, Point p2)
        {
            return (float)Math.Sqrt(Math.Pow(p1.x - p2.x, 2) + Math.Pow(p1.y - p2.y, 2));
        }
        public static void The2furthestpoints(List<Point> p)
        {
            float d = 0, dmax = Distance_2_Points(p[0], p[1]);
            int imax = 1, jmax = 2;
            for (int i = 0; i < p.Count - 1; i++)
            {
                for (int j = i + 1; j < p.Count; j++)
                {
                    d = Distance_2_Points(p[i], p[j]);
                    if (d > dmax)
                    {
                        dmax = d;
                        imax = i + 1;
                        jmax = j + 1;
                    }
                }
            }
            Console.WriteLine("Đoạn thẳng lớn nhất có độ dài: d = {0:0.00}", dmax);
            Console.WriteLine("Đi qua điểm p{0}({1:0.00}, {2:0.00}) và p{3}({4:0.00}, {5:0.00})",
                    imax, p[imax - 1].x, p[imax - 1].y, jmax, p[jmax - 1].x, p[jmax - 1].y);
        }

    }
}