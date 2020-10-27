#include <stdio.h>
#include <string.h>
#include <math.h>
#include <stdlib.h>

int main() {
	
    int n, i;
    int sum = 0;
    int digit = 0;
    int divider = 10000;
    
    scanf("%d", &n);
 
    for (i = 1; i < 5; i++)
    {
        digit = n / divider;
        sum += digit;
        n -= digit * divider;
        divider /= 10;
    }
    sum += n;
    printf("%d", sum);

    return 0;
}