using Green;
namespace Const_Struct
{
    class Program
    {
        public const double pi = 3.14;
        private const int password = 24091992;
        public static bool check_pass(int pass)
        {
            if (pass == password) return true;
            else return false;
        }
        public struct Point
        {
            public int x;
            public int y;
            public Point(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
        }
        public static readonly Point p = new Point(10, 15);
        //! p cant edit value....
        public static Point p2 = new Point(2, 3);
        //! p2 can change value... 
        static void Main(string[] args)
        {

            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine(p.x);
            Console.WriteLine(p.y);
            Console.WriteLine(p2.x);
            Console.WriteLine(p2.y);
            p2.x = 22;
            p2.y = 33;
            Console.WriteLine(p2.x);
            Console.WriteLine(p2.y);
            Console.WriteLine(pi);
            Console.Write("Nhập mật khẩu: pass = ");
            int pass = Class_Collection.Int_Input("nhập sai, thử lại: ");
            Console.WriteLine(check_pass(pass));
            while (!check_pass(pass))
            {
                Console.Write("Nhập mật khẩu: pass = ");
                pass = Class_Collection.Int_Input("nhập sai, thử lại: ");
                Console.WriteLine(check_pass(pass));
            }
            Console.ReadKey();
        }
    }
}