#https://www.hackerrank.com/challenges/sherlock-and-squares/problem

import math
import os
import random
import re
import sys

# Complete the squares function below.
def squares(a, b):
    i = 1
    result = 0
    while(True):
        t = i * i 
        if (t > b):
            break
        if (t >= a and t <= b):
            result = result + 1
        i = i + 1
    return result

if __name__ == '__main__':
    q = int(input())
    for q_itr in range(q):
        ab = input().split()
        a = int(ab[0])
        b = int(ab[1])
        result = squares(a, b)
        print(str(result) + '\n')

