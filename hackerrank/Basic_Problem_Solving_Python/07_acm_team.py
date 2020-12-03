#https://www.hackerrank.com/challenges/acm-icpc-team/problem

import math
import os
import random
import re
import sys

# Complete the acmTeam function below.
def acmTeam(topic):
    pool = []
    l = len(topic)
    for i in range(l):
        for j in range(i+1,l):
            item = 0
            for x in range(len(topic[0])):
                if(topic[i][x] == '1' or topic[j][x] == '1'):
                    item = item + 1
            pool.append(item)
    res = []
    res.append(max(pool))
    res.append(pool.count(max(pool)))
    return res

if __name__ == '__main__':
    nm = input().split()
    n = int(nm[0])
    m = int(nm[1])
    topic = []
    for _ in range(n):
        topic_item = input()
        topic.append(topic_item)
    result = acmTeam(topic)

    print('\n'.join(map(str, result)))
    print('\n')
