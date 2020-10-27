#include <stdio.h>

#define MAX_LEN 0xFF 

int main()
{
    char c;             
    char buf1[MAX_LEN];  
    char buf2[MAX_LEN];  

    scanf("%c"  ,&c);
    scanf("\n%s",buf1);
    scanf("\n%[^\n]%*c", buf2);

    printf("%c", c);
    printf("\n%s", buf1);
    printf("\n%s", buf2);    

    return 0;
}