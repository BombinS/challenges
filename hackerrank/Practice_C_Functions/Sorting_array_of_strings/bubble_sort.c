#include <stdio.h>


void sort(int* data, int len)
{
    int isFinished = 0;
    while (!isFinished)
    {
        int i;
        char tmp;

        isFinished = 1;
        for(i = 0; i < len - 1; i++ )
        {
            if (data[i] > data[i+1])
            {
                tmp = data[i];
                data[i] = data[i+1];
                data[i+1] = tmp;
                isFinished = 0;
            }
        }
    }    
}

int main()
{
    int data_1[] = {4, 3, 2, 1};
    printf("before: %d %d %d %d\n", data_1[0], data_1[1], data_1[2], data_1[3]);
    sort(data_1, 4);
    printf("after : %d %d %d %d\n", data_1[0], data_1[1], data_1[2], data_1[3]);

    return 0;    
}