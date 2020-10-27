#include <stdio.h>
#include <string.h>
#include <math.h>
#include <stdlib.h>

int getMax(int a, int b)
{
    if (a>b)
        return a;
    return b;
}

int main() 
{

    int n;
    scanf("%d", &n);

    int dimension = n * 2 - 1;
    int i,j;

    for (i = 1; i <= dimension; i++)
    {
        if ((n-i) > 0)
        {
            for (j = 1; j <= dimension ; j++)
            {
                if (n-j >0)
                    printf("%d ", getMax(n-i+1 , n-j+1));               
                else
                    printf("%d ", getMax(n-i+1 , j-n+1));               
            }
        } 
        else 
        {
            for (j = 1; j <= dimension ; j++)
            {
                if (n-j >0)
                    printf("%d ", getMax(i-n+1 , n-j+1));               
                else
                    printf("%d ", getMax(i-n+1 , j-n+1));               
            }
        }
        
        printf("\n");
    }
    
    return 0;
}