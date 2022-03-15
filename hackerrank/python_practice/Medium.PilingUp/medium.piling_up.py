from tkinter.messagebox import NO
from turtle import left


def makeDecision(numbers):
    result = 'Yes'
    last = 0
    
    leftValue = numbers[0]
    rightValue = numbers[-1]
    if leftValue > rightValue:
        last = leftValue
    else:
        last = rightValue

    while len(numbers) > 0:
        leftValue = numbers[0]
        rightValue = numbers[-1]
        if (leftValue > rightValue and leftValue <= last):
            last = leftValue
            del numbers[0]
        elif (rightValue <= last):
            last = rightValue
            del numbers[-1]
        else:
            result = 'No'
            break
    return result   

def convertToInt(strinBuf):
    n = []
    for s in strinBuf.split():
        n.append(int(s))
    return n;

def proc(str):
    numbers = convertToInt(str)
    print(makeDecision(numbers))

def main():
    sBuf = ['3', '6', '4 3 2 1 3 4', '3', '1 3 2', '1', '123']
    print(sBuf)
    offset = 2
    n = int(sBuf[0])
    for i in range(n):
        proc(sBuf[offset])
        offset = offset + 2

if __name__ == '__main__':
    main()