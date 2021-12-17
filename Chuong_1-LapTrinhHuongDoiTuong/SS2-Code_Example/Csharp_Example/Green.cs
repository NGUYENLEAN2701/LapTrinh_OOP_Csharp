namespace Green
{
    class S_TamGiac
    {
        public static void s_tamgiac()
        {
            Console.WriteLine("Xin nhập độ dài 3 cạnh của tam giác: ");
            Console.Write("a = ");
            float a = 0;
            while (!float.TryParse(Console.ReadLine(), out a))
            {
                Console.Write("Bạn nhập sai - thử lại: a = ");
            }
            Console.Write("b = ");
            float b = 0;
            while (!float.TryParse(Console.ReadLine(), out b))
            {
                Console.Write("Bạn nhập sai - thử lại: b = ");
            }
            Console.Write("c = ");
            float c = 0;
            while (!float.TryParse(Console.ReadLine(), out c))
            {
                Console.Write("Bạn nhập sai - thử lại: c = ");
            }
            //tính S tam giác:
            float p = (a + b + c) / 2;

            if (p <= a || p <= b || p <= c)
            {
                Console.WriteLine("Độ dài 3 cạnh đã nhập ko tạo thành Tam Giác!");
            }
            else
            {
                double s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                Console.WriteLine("Diện Tích Tam Giác là: S = {0:0.00}", s);
            }

        }
    }
}