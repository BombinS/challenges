from itertools import count


def count_substring(string, sub_string):
    result = 0
    l1 = len(string)
    l2 = len(sub_string)
    i = 0
    while (l1 - i >= l2):
        if (string[i : i + l2] == sub_string):
            result = result + 1
        i = i + 1
    return result


def main():
    s1 = 'ABCDCDCCC'
    s2 = 'C'     
    print(count_substring(s1, s2))

if __name__ == '__main__':
    main()