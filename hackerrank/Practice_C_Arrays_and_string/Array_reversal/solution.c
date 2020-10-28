// https://www.hackerrank.com/challenges/reverse-array-c/problem

#include <stdio.h>
#include <stdlib.h>

int main()
{
    int num, *arr, i;
    scanf("%d", &num);
    arr = (int*) malloc(num * sizeof(int));
    for(i = 0; i < num; i++) {
        scanf("%d", arr + i);
    }

    /* Write the logic to reverse the array. */
    int half = num / 2;
    int tmp;
    for (i = 0; i < half; i++)
    {
        tmp = arr[i];
        arr[i] = arr[num-1-i];
        arr[num-1-i] = tmp;
    }

    for(i = 0; i < num; i++)
        printf("%d ", *(arr + i));
    return 0;
}