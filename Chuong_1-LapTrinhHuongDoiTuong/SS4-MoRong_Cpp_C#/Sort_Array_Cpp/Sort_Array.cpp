#include <stdio.h>
#include <conio.h>
#include <time.h>   //for time()
#include <stdlib.h> //for srand
void nhapsl_auto(int n, float *x)
{
    srand(time(0));
    for (int i = 1; i <= n; i++)
    {
        x[i] = (float)(rand() % 10000 - 5000);
    }
}
void sortArray(int n, float *x)
{
    for (int i = 1; i <= n; i++)
        for (int j = i + 1; j <= n; j++)
            if (x[i] > x[j])
            {
                float tg = x[i];
                x[i] = x[j];
                x[j] = tg;
            }
}
void showArray(int n, float *x)
{
    printf("\n");
    for (int i = 1; i <= n; i++)
        printf("\n%0.2f", x[i]);
}
int main(void)
{
    int start = time(0);
    int n = 1000000; //!=> 16s to finish
    // printf("\nSo Phan Tu Cua Day N = ");
    // scanf("%d", &n);
    float *x = (float *)malloc((n + 1) * sizeof(float));
    nhapsl_auto(n, x);
    // showArray(n, x);
    sortArray(n, x);
    // showArray(n, x);
    printf("\n%d ", time(0) - start);
    return 0;
}