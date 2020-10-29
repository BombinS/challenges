// https://www.hackerrank.com/challenges/sorting-array-of-strings/problem

#include <stdio.h>
#include <stdlib.h>
#include <string.h>

int lexicographic_sort(const char* a, const char* b) {
    int i = 0;
    while(1)
    {
        if (a[i] < b[i])
            return -1;
        if (a[i] > b[i] )
            return 1;     
        if (a[i] == 0 && b[i] == 0)
            return 0;
        i++;    
    }
    return 0;
}

int lexicographic_sort_reverse(const char* a, const char* b) {
    int i = 0;
    while(1)
    {
        if (a[i] > b[i])
            return -1;
        if (a[i] < b[i] )
            return 1;     
        if (a[i] == 0 && b[i] == 0)
            return 0;
        i++;    
    }
    return 0;
}

int sort_by_number_of_distinct_characters(const char* a, const char* b) {
    int i;    
    int number_distinct_a = 0;
    int number_distinct_b = 0;

    char *poll_distinct_a = (char*)malloc(sizeof(char));
    i = 0;
    while(a[i] != 0)
    {
        int isDistinct = 1;
        int j;
        for(j = 0; j < number_distinct_a; j++)
        {
            if (poll_distinct_a[j] == a[i])
            {
                isDistinct = 0;
                break;
            }
        }
        if (isDistinct)
        {
            number_distinct_a++;
            poll_distinct_a = (char*)realloc(poll_distinct_a, number_distinct_a * sizeof(char));
            poll_distinct_a[number_distinct_a - 1] = a[i];
        }
        i++;
    }

    char *poll_distinct_b = (char*)malloc(sizeof(char));
    i = 0;
    while(b[i] != 0)
    {
        int isDistinct = 1;
        int j;
        for(j = 0; j < number_distinct_b; j++)
        {
            if (poll_distinct_b[j] == b[i])
            {
                isDistinct = 0;
                break;
            }
        }
        if (isDistinct)
        {
            number_distinct_b++;
            poll_distinct_b = (char*)realloc(poll_distinct_b, number_distinct_b * sizeof(char));
            poll_distinct_b[number_distinct_b - 1] = b[i];
        }
        i++;
    }

    free(poll_distinct_a);
    free(poll_distinct_b);

    if (number_distinct_a < number_distinct_b)
        return -1;
    else if(number_distinct_a > number_distinct_b)
        return 1;
    else
        return lexicographic_sort(a, b);
}

int sort_by_length(const char* a, const char* b) {  

    int i = 0;
    while(1)
    {
        if (a[i] == 0 && b[i] != 0)
            return -1;
        if (a[i] != 0 && b[i] == 0)
            return 1;     
        if (a[i] == 0 && b[i] == 0)
            return lexicographic_sort(a, b);
        i++;    
    }
    
    return 0;
}

void string_sort(char** arr, const int len, int (*cmp_func)(const char* a, const char* b)){

    // bubble sort
    int isFinished = 0;
    while (!isFinished)
    {
        int i;
        char* tmp;

        isFinished = 1;
        for(i = 0; i < len - 1; i++ )
        {
            if (cmp_func(arr[i], arr[i+1]) == 1)
            {
                tmp = arr[i];
                arr[i] = arr[i+1];
                arr[i+1] = tmp;
                isFinished = 0;
            }
        }
    }         
}


int main() 
{
    int n;
    scanf("%d", &n);
  
    char** arr;
	arr = (char**)malloc(n * sizeof(char*));
  
    for(int i = 0; i < n; i++){
        *(arr + i) = malloc(1024 * sizeof(char));
        scanf("%s", *(arr + i));
        *(arr + i) = realloc(*(arr + i), strlen(*(arr + i)) + 1);
    }
  
    string_sort(arr, n, lexicographic_sort);
    for(int i = 0; i < n; i++)
        printf("%s\n", arr[i]);
    printf("\n");

    string_sort(arr, n, lexicographic_sort_reverse);
    for(int i = 0; i < n; i++)
        printf("%s\n", arr[i]); 
    printf("\n");

    string_sort(arr, n, sort_by_length);
    for(int i = 0; i < n; i++)
        printf("%s\n", arr[i]);    
    printf("\n");

    string_sort(arr, n, sort_by_number_of_distinct_characters);
    for(int i = 0; i < n; i++)
        printf("%s\n", arr[i]); 
    printf("\n");
}