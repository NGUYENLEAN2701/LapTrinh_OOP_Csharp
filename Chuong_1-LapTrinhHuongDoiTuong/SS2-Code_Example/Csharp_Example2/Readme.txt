Hướng Dẫn tạo Solution C#!

Bước 1: 
    +mở terminal folder muốn tạo sln...
    +terminal code: dotnet new sln
Bước 2: 
    +tạo folder library,terminal code: dotnet new classlib -o StringLibrary
    +add library vào sln,terminal code: dotnet sln add StringLibrary/StringLibrary.csproj
    +StringLibrary/StringLibrary.csproj -> kiểm tra file:

<Project Sdk="Microsoft.NET.Sdk">

  <PropertyGroup>
    <TargetFramework>net6.0</TargetFramework>
  </PropertyGroup>

</Project>

    +mở Class1.cs và chép vào đoạn code test:

namespace UtilityLibraries;

public static class StringLibrary
{
    public static bool StartsWithUpper(this string? str)
    {
        if (string.IsNullOrWhiteSpace(str))
            return false;

        char ch = str[0];
        return char.IsUpper(ch);
    }
}

    +chạy thử Class1.cs -> terminal code: dotnet run

bước 3:
    +tạo chương trình chính, terminal code: dotnet new console -o ShowCase
    +add chương trình chính vào sln, terminal code: dotnet sln add ShowCase/ShowCase.csproj
    +mở ShowCase/Program.cs chép vào code test, nhưng ko build chương trình:

using UtilityLibraries;

class Program
{
    static void Main(string[] args)
    {
        int row = 0;

        do
        {
            if (row == 0 || row >= 25)
                ResetConsole();

            string? input = Console.ReadLine();
            if (string.IsNullOrEmpty(input)) break;
            Console.WriteLine($"Input: {input}");
            Console.WriteLine("Begins with uppercase? " +
                 $"{(input.StartsWithUpper() ? "Yes" : "No")}");
            Console.WriteLine();
            row += 4;
        } while (true);
        return;

        // Declare a ResetConsole local method
        void ResetConsole()
        {
            if (row > 0)
            {
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
            Console.Clear();
            Console.WriteLine($"{Environment.NewLine}Press <Enter> only to exit; otherwise, enter a string and press <Enter>:{Environment.NewLine}");
            row = 3;
        }
    }
}

    +add library vào chương trình chính, terminal code: dotnet add ShowCase/ShowCase.csproj reference StringLibrary/StringLibrary.csproj
bước 4:
    +build và chạy chương trình, terminal code: dotnet run --project ShowCase/ShowCase.csproj

->trên là các bước tạo và sử dụng thư viện riêng cho một chương trình C#