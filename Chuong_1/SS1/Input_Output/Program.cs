using System.Diagnostics;
Console.OutputEncoding = System.Text.Encoding.Unicode;
Console.InputEncoding = System.Text.Encoding.Unicode;
Console.WriteLine("Hello World!");
Console.Write("Xin Nhập Tên Bạn: ");
var Name = Console.ReadLine();
Console.WriteLine("Chào Mừng {0} Đến Với C#", Name);
var ps = new ProcessStartInfo("https://nguyenlean.com/index.php")
{
    UseShellExecute = true,
    Verb = "open"
};
//Process.Start(ps);