def main():

    n = 4
    str1 = "bcdef"
    str2 = "abcdefg"
    str3 = "bcde"
    str4 = "bcdef"
    listOfString = [str1, str2, str3, str4]

    bufDict = {}
    for s in listOfString:
        if s not in bufDict:
            bufDict[s] = 1
        else:
            bufDict[s] = bufDict[s] + 1

    print(len(bufDict))
    for k, v in bufDict.items():
        print(v, end=' ')
    

if __name__ == '__main__':
    main()