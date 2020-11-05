// https://www.hackerrank.com/challenges/post-transition/problem

#include <stdio.h>
#include <stdlib.h>
#define MAX_STRING_LENGTH 6

struct package
{
	char* id;
	int weight;
};

typedef struct package package;

struct post_office
{
	int min_weight;
	int max_weight;
	package* packages;
	int packages_count;
};

typedef struct post_office post_office;

struct town
{
	char* name;
	post_office* offices;
	int offices_count;
};

typedef struct town town;

void print_all_packages(town t) {
    int i,j;
    printf("%s:\n", t.name);
    for(i = 0; i < t.offices_count; i++)
    {
        printf("\t%d:\n", i);
        for(j = 0; j < t.offices[i].packages_count; j++)
        {
            printf("\t\t%s\n", t.offices[i].packages[j].id);
        }
    }
}

void send_all_acceptable_packages(town* source, int source_office_index, town* target, int target_office_index) {	
    package* tmp = (package*)malloc(sizeof(package));
    int tmpCount = 0;
    int i;
    for(i = 0; i < source -> offices[source_office_index].packages_count; i++)
    {
        int min = target -> offices[target_office_index].min_weight;
        int max = target -> offices[target_office_index].max_weight;
        package p = source -> offices[source_office_index].packages[i];
        if (p.weight >= min && p.weight <= max)
        {
            target -> offices[target_office_index].packages = (package*)realloc(target -> offices[target_office_index].packages, ++(target -> offices[target_office_index].packages_count)*sizeof(package));
            target -> offices[target_office_index].packages[target -> offices[target_office_index].packages_count - 1] = p;
        }
        else 
        {
            tmp = (package*)realloc(tmp, (++tmpCount * sizeof(package)));
            tmp[tmpCount - 1] = p; 
        }
    }
    free(source -> offices[source_office_index].packages);
    source -> offices[source_office_index].packages = (package*)malloc(tmpCount* sizeof(package));
    for(i=0; i < tmpCount; i++)
    {
        source -> offices[source_office_index].packages[i] = tmp[i]; 
		source -> offices[source_office_index].packages_count = tmpCount; 
    }
    free(tmp);
}

town town_with_most_packages(town* towns, int towns_count) {
    int i, j;
	int max = 0;
	int max_index = 0;
	for(i = 0; i < towns_count; i++)
	{
		int current_sum = 0;
		for(j = 0; j < towns[i].offices_count; j++)
		{
			current_sum += towns[i].offices[j].packages_count;
		}
		if (current_sum > max)
		{
			max = current_sum;
			max_index = i;
		}
	}
	return towns[max_index];
}

town* find_town(town* towns, int towns_count, char* name){
	int i;
	int j = 0;
	
	for(i = 0; i < towns_count; i++)
	{
		int isFound = 1;
		while (towns[i].name[j] != 0 || name[j] != 0)
		{
			if (towns[i].name[j] != name[j])
			{
				isFound = 0;
				break;
			}
			j++;
		}
		if (isFound == 1 && towns[i].name[j] == 0 && name[j] == 0 )
		{
			return &towns[i];
		}
	}
	return 0;
}

int main()
{
	int towns_count;
	scanf("%d", &towns_count);
	town* towns = malloc(sizeof(town)*towns_count);
	for (int i = 0; i < towns_count; i++) {
		towns[i].name = malloc(sizeof(char) * MAX_STRING_LENGTH);
		scanf("%s", towns[i].name);
		scanf("%d", &towns[i].offices_count);
		towns[i].offices = malloc(sizeof(post_office)*towns[i].offices_count);
		for (int j = 0; j < towns[i].offices_count; j++) {
			scanf("%d%d%d", &towns[i].offices[j].packages_count, &towns[i].offices[j].min_weight, &towns[i].offices[j].max_weight);
			towns[i].offices[j].packages = malloc(sizeof(package)*towns[i].offices[j].packages_count);
			for (int k = 0; k < towns[i].offices[j].packages_count; k++) {
				towns[i].offices[j].packages[k].id = malloc(sizeof(char) * MAX_STRING_LENGTH);
				scanf("%s", towns[i].offices[j].packages[k].id);
				scanf("%d", &towns[i].offices[j].packages[k].weight);
			}
		}
	}
	int queries;
	scanf("%d", &queries);
	char town_name[MAX_STRING_LENGTH];
	while (queries--) {
		int type;
		scanf("%d", &type);
		switch (type) {
		case 1:
			scanf("%s", town_name);
			town* t = find_town(towns, towns_count, town_name);
			print_all_packages(*t);
			break;
		case 2:
			scanf("%s", town_name);
			town* source = find_town(towns, towns_count, town_name);
			int source_index;
			scanf("%d", &source_index);
			scanf("%s", town_name);
			town* target = find_town(towns, towns_count, town_name);
			int target_index;
			scanf("%d", &target_index);
			send_all_acceptable_packages(source, source_index, target, target_index);
			break;
		case 3:
			printf("Town with the most number of packages is %s\n", town_with_most_packages(towns, towns_count).name);
			break;
		}
	}
	return 0;
}