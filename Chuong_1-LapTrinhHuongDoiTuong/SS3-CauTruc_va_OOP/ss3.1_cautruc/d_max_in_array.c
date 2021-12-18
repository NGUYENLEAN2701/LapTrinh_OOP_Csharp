#include <stdio.h>
#include <conio.h>
#include <math.h>
#include <time.h>   //for time()
#include <stdlib.h> //for srand
float x[100] = {0};
float y[100] = {0};
float do_dai(int i, int j)
{
    return sqrt(pow(x[i] - x[j], 2) + pow(y[i] - y[j], 2));
}

void nhapsl(int n)
{
    for (int i = 1; i <= n; i++)
    {
        printf("\nNhap toa do cua diem thu %d: ", i);
        scanf("%f%f", &x[i], &y[i]);
    }
}
void nhapsl_auto(int n)
{
    srand(time(0));
    for (int i = 1; i <= n; i++)
    {
        x[i] = (float)(rand() % 10000 - 5000) / 100;
        y[i] = (float)(rand() % 10000 - 5000) / 100;
    }
}

int main(void)
{
    int n, imax, jmax;
    int ch = 1;
    float d, dmax;
    printf("\nSo diem N = ");
    scanf("%d", &n);
    printf("\n1-tu nhap tay du lieu");
    printf("\n2-tu dong cho du lieu");
    printf("\nChon : ");
    scanf("%d", &ch);
    if (ch == 1)
        nhapsl(n);
    else
        nhapsl_auto(n);
    printf("\nDu lieu - toa do cac diem:");
    for (int i = 1; i <= n; i++)
        printf("\ndiem %d (%0.2f, %0.2f)", i, x[i], y[i]);
    dmax = do_dai(1, 2);
    imax = 1;
    jmax = 2;
    for (int i = 1; i <= n - 1; i++)
    {
        for (int j = i + 1; j <= n; j++)
        {
            d = do_dai(i, j);
            if (d > dmax)
            {
                dmax = d;
                imax = i;
                jmax = j;
            }
        }
    }
    printf("\nDoan thang lon nhat co do dai = %0.2f", dmax);
    printf("\nDi qua diem %d (%0.2f, %0.2f) & diem %d (%0.2f, %0.2f)", imax, x[imax], y[imax], jmax, x[jmax], y[jmax]);
    getch();
    return 0;
}
