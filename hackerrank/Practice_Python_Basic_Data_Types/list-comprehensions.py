# https://www.hackerrank.com/challenges/list-comprehensions/problem

if __name__ == '__main__':
    x = int(input())
    y = int(input())
    z = int(input())
    n = int(input())
    result = list()
    for dx in range(x+1):
        for dy in range(y+1):
            for dz in range(z+1): 
                if ((dx + dy + dz) != n):
                    tmp = list()
                    tmp.append(dx)
                    tmp.append(dy)
                    tmp.append(dz)
                    result.append(tmp)
    print(result)