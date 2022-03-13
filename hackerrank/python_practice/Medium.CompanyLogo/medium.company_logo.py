
from inspect import getmembers
from unittest import result


def getMax(d):
    maxValue = 0
    minChar = 0
    for k, v in d.items():
        if v > maxValue:
            maxValue = v
            minChar = k
        if v == maxValue and k < minChar:
            minChar = k
    return [minChar, maxValue]

def main():
    # s = input()
    s = "aabbbccde"
    
    d = {}
    for c in s:
        if c not in d:
            d[c] = 1
        else:
            d[c] = d[c] + 1
    
    result = []

    max = getMax(d);
    result.append(max)
    del d[max[0]]

    max = getMax(d);
    result.append(max)
    del d[max[0]]

    max = getMax(d);
    result.append(max)
    del d[max[0]]

    for r in result:
        print(r[0],r[1])


if __name__ == '__main__':
    main()
