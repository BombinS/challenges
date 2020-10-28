// https://www.hackerrank.com/challenges/1d-arrays-in-c/problem

#include <stdio.h>
#include <string.h>
#include <math.h>
#include <stdlib.h>

int main() {

    // read the number of integers
    int n;
    scanf("%d", &n);

    // allocate memory
    int *p = (int*)malloc(n*sizeof(int));

    // get numbers
    int i;
    for (i = 0; i < n; i++)
    {
        scanf("%d", &p[i]);
    }

    // obtain the sum
    int sum = 0;
    for (i = 0; i < n; i++)
    {
        sum += p[i];
    }

    // print sum
    printf("%d", sum);

    // free memoty
    free(p);

    return 0;
}