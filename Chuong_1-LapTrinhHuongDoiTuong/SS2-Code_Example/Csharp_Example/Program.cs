using System.Diagnostics;
using Green;
Console.OutputEncoding = System.Text.Encoding.Unicode;
Console.InputEncoding = System.Text.Encoding.Unicode;
Console.Write("Xin nhập tên bạn: ");
string? ten_ban = Console.ReadLine();
Console.WriteLine("Xin Chào, Bạn {0}!", ten_ban);
S_TamGiac.s_tamgiac();
Console.WriteLine("Bạn có muốn xem website: nguyenlean.com?");
Console.Write("1-Có | 2-Không -> Chọn: ");
int ch = 1;
while (!int.TryParse(Console.ReadLine(), out ch))
{
    Console.Write("Bạn nhập sai - thử chọn lại: ");
}
if (ch == 1)
{
    var ps = new ProcessStartInfo("https://nguyenlean.com/index.php")
    {
        UseShellExecute = true,
        Verb = "open"
    };
    Process.Start(ps);
}
else
{
    Console.WriteLine("Hẹn Gặp Lại!");
    Console.ReadKey();
}
