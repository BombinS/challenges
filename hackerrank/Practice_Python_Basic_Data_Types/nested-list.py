# https://www.hackerrank.com/challenges/nested-list/problem

if __name__ == '__main__':
    holder = list();
    scores = list();
    for _ in range(int(input())):
        name = input()
        score = float(input())
        holder.append([name,score])
        scores.append(score)
    uniqueScores = sorted(set(scores))
    secondScore = uniqueScores[1]

    nameHolder = list()
    for item in holder:
        if item[1] == secondScore:
            nameHolder.append(item[0])
    
    sortedNameHolder = sorted(nameHolder)
    for item in sortedNameHolder:
        print(item)