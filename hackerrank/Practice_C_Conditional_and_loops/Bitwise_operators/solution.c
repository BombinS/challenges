#include <stdio.h>
#include <string.h>
#include <math.h>
#include <stdlib.h>
//Complete the following function.


void calculate_the_maximum(int n, int k) {

  int i, j, maxAnd, maxOr, maxXor, thisAnd, thisOr, thisXor;
  maxAnd = maxOr = maxXor = 0;

  for( i = 1; i < n ; i++)
  {
      
      for (j = i + 1; j <= n; j++)
      {
          thisAnd = i & j;
          thisOr =  i | j;
          thisXor = i ^ j;
          //printf("  i = %d, j = %d, and = %d, or = %d, xor = %d\n" , i, j, thisAnd, thisOr, thisXor);
          if (thisAnd > maxAnd && thisAnd < k)
            { maxAnd = thisAnd; }
          if (thisOr > maxOr && thisOr < k)
            { maxOr = thisOr; }
          if (thisXor > maxXor && thisXor < k)
            { maxXor = thisXor; }
      }
  }
  printf("%d\n", maxAnd);
  printf("%d\n", maxOr);
  printf("%d", maxXor);

}

int main() {
    int n, k;
  
    scanf("%d %d", &n, &k);
    calculate_the_maximum(n, k);
 
    return 0;
}