#include <iostream>
#include <conio.h>
#include <math.h>
using namespace std;

int main()
{
    float a, b, c, p, s;
    cout << "Nhap a, b, c: ";
    cin >> a >> b >> c;
    p = (a + b + c) / 2;
    s = sqrt(p * (p - a) * (p - b) * (p - c));
    cout << "Dien Tich = " << s << endl;
    getch();
    return 0;
}
