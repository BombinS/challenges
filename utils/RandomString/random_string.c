#include <stdio.h>
#include <stdlib.h>
#include <time.h>

int main()
{
    srand(time(0));

    int n, i;
    scanf("%d",&n);

    FILE *fp = fopen("dump.info", "w+");
    for (i = 0; i < n; i++)
    {
        fputc(rand() % 26 + 97, fp);    
    }

    fclose(fp);
}