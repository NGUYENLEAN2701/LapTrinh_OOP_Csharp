#include <stdio.h>
#include <conio.h>
#include <math.h>
int main(void)
{
    float a, b, c, p, s;
    printf("\nNhap a, b, c: ");
    scanf("%f%f%f", &a, &b, &c);
    p = (a + b + c) / 2;
    s = sqrt(p * (p - a) * (p - b) * (p - c));
    printf("\nDien tich = %0.2f", s);
    getch();
    return 0;
}