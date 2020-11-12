#https://www.hackerrank.com/challenges/finding-the-percentage/problem

if __name__ == '__main__':
    n = int(input())
    student_marks = {}
    for _ in range(n):
        name, *line = input().split()
        scores = list(map(float, line))
        student_marks[name] = scores
    query_name = input()

    sum = 0.0
    for score in student_marks[query_name]:
        sum = sum + score
    
    print("{:.2f}".format(sum/len(student_marks[query_name])))