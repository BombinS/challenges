#https://www.hackerrank.com/challenges/append-and-delete/problem

import math
import os
import random
import re
import sys

# Complete the appendAndDelete function below.
def appendAndDelete(s, t, k):
    la = len(s)
    lb = len(t)
    if (la + lb <= k):
        return 'Yes'
    else:
        dx = 0
        for z in range(min(la,lb)):
            if (s[z] == t[z]):
                dx = dx + 1
            else:
                break
        dk = (la - dx) + (lb - dx)
        if (dk == k or (k > dk and (dk + k) % 2 == 0)):
            return 'Yes'
        else:
            return('No')

if __name__ == '__main__':
    s = input()
    t = input()
    k = int(input()) 
    result = appendAndDelete(s, t, k)
    print(result + '\n')
