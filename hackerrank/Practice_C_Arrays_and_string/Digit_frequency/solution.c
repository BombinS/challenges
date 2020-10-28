// https://www.hackerrank.com/challenges/frequency-of-digits-1/problem

#include <stdio.h>
#include <string.h>
#include <math.h>
#include <stdlib.h>

int main() {

    char buf[1000];
    scanf("%s", buf);
 
    int *counters = (int*)calloc(10, sizeof(int));

    int i;
    for (i = 0; i < strlen(buf); i++)
    {
        if (buf[i] == '0')
            (*(counters + 0))++;
        if (buf[i] == '1')
            (*(counters + 1))++;
        if (buf[i] == '2')
            (*(counters + 2))++;                        
        if (buf[i] == '3')
            (*(counters + 3))++;
        if (buf[i] == '4')
            (*(counters + 4))++;
        if (buf[i] == '5')
            (*(counters + 5))++;
        if (buf[i] == '6')
            (*(counters + 6))++;
        if (buf[i] == '7')
            (*(counters + 7))++;
        if (buf[i] == '8')
            (*(counters + 8))++;                        
        if (buf[i] == '9')
            (*(counters + 9))++;                        
    }

    printf("%d %d %d %d %d %d %d %d %d %d", counters[0], counters[1], counters[2], counters[3], counters[4], counters[5], counters[6], counters[7], counters[8], counters[9]);

    return 0;
}