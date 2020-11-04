// https://www.hackerrank.com/challenges/small-triangles-large-triangles/problem

#include <stdio.h>
#include <stdlib.h>
#include <math.h>

struct triangle
{
	int a;
	int b;
	int c;
};

#define P(a, b, c) (a + b + c)/2.0  
#define S(a, b, c) sqrt( P(a, b, c) * (P(a, b, c) - a) *  (P(a, b, c) - b) *  (P(a, b, c) - c) )

typedef struct triangle triangle;
void sort_by_area(triangle* tr, int n) {
	/**
	* Sort an array a of the length n
	*/
    triangle tmp;
    int isFinished = 0;
    while(isFinished == 0)
    {
        isFinished = 1;
        int i;
        for (i = 0; i < n - 1; i++)
        {
            if (S(tr[i].a, tr[i].b, tr[i].c) > S(tr[i+1].a, tr[i+1].b, tr[i+1].c))
            {
                tmp = tr[i];
                tr[i] = tr[i+1];
                tr[i+1] = tmp;
                isFinished = 0;
            }
        }
    }

}

int main()
{
	int n;
	scanf("%d", &n);
	triangle *tr = malloc(n * sizeof(triangle));
	for (int i = 0; i < n; i++) {
		scanf("%d%d%d", &tr[i].a, &tr[i].b, &tr[i].c);
	}
    
    printf("S1 - %f\n", S(tr[0].a, tr[0].b, tr[0].c));
    printf("S2 - %f\n", S(tr[1].a, tr[1].b, tr[1].c));

	sort_by_area(tr, n);
	for (int i = 0; i < n; i++) {
		printf("%d %d %d\n", tr[i].a, tr[i].b, tr[i].c);
	}
	return 0;
}