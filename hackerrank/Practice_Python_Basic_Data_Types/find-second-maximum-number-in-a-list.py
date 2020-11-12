# https://www.hackerrank.com/challenges/find-second-maximum-number-in-a-list/problem

if __name__ == '__main__':
    n = int(input())
    arr = map(int, input().split())
    sortedArr = sorted(list(arr), reverse=True)
    result = sortedArr[0]
    for x in range(1,n):
        if sortedArr[x] != result:
            result = sortedArr[x]
            break; 
    print(result)