#include <stdio.h>
#include <conio.h>
typedef struct
{
    int x, y;
    int color;
} DIEM;

int main()
{
    const DIEM p_zero = {0, 0, 255};
    printf("\n%d", p_zero.x);
    printf("\n%d", p_zero.y);
    printf("\n%d", p_zero.color);
    return 0;
}