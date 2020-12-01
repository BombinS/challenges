#https://www.hackerrank.com/challenges/cut-the-sticks/problem

#!/bin/python3

import math
import os
import random
import re
import sys

# Complete the cutTheSticks function below.
def cutTheSticks(arr):
    isFinished = False
    pool = []
    while (isFinished == False):
        isFinished = True
        sum = 0
        minimum = min(arr)
        newArr = []
        for x in arr:
            sum = sum + 1
            if (x - minimum != 0):
                newArr.append(x - minimum)
                isFinished = False
        pool.append(sum)
        arr = newArr
    return pool

if __name__ == '__main__':
    n = int(input())
    arr = list(map(int, input().rstrip().split()))
    result = cutTheSticks(arr)
    print('\n'.join(map(str, result)))
    print('\n')

