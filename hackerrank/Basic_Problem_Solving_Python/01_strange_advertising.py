#https://www.hackerrank.com/challenges/strange-advertising/problem

import math
import os
import random
import re
import sys

# Complete the viralAdvertising function below.
def viralAdvertising(n):
    shared = 5
    liked = math.floor(5 / 2)
    shared = liked * 3
    cumulative = liked
    for x in range(1, n):
        liked = math.floor(shared / 2)
        cumulative = cumulative + liked
        shared = liked * 3
    return cumulative

if __name__ == '__main__':
    n = int(input())
    result = viralAdvertising(n)
    print(str(result) + '\n')
