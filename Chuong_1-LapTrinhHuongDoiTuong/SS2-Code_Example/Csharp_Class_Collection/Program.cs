using Green;
Console.OutputEncoding = System.Text.Encoding.Unicode;
Console.InputEncoding = System.Text.Encoding.Unicode;
Console.WriteLine("Hello, World!");
Console.Write("Nhập: i = ");
int i = Class_Collection.Int_Input("i");
while (i < 2 || i > 10)
{
    Console.Write("nhập sai, thử lại: i = ");
    i = Class_Collection.Int_Input("i");
}
Console.WriteLine("i = {0}", i);