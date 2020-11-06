// https://www.hackerrank.com/challenges/structuring-the-document/problem

#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <assert.h>
#define MAX_CHARACTERS 1005
#define MAX_PARAGRAPHS 5

#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <assert.h>
#define MAX_CHARACTERS 1005
#define MAX_PARAGRAPHS 5

struct word {
    char* data;
};

struct sentence {
    struct word* data;
    int word_count;//denotes number of words in a sentence
};

struct paragraph {
    struct sentence* data  ;
    int sentence_count;//denotes number of sentences in a paragraph
};

struct document {
    struct paragraph* data;
    int paragraph_count;//denotes number of paragraphs in a document
};


typedef struct document document;
typedef struct paragraph paragraph;
typedef struct sentence sentence;
typedef struct word word;

struct document get_document(char* text) {
    document Doc;

    Doc.paragraph_count = 1;
    int pCount = Doc.paragraph_count;
    Doc.data = (paragraph*)malloc(sizeof(paragraph));

    Doc.data[pCount - 1].sentence_count = 1;
    int sCount = Doc.data[pCount - 1].sentence_count;
    Doc.data[pCount - 1].data = (sentence*)malloc(sizeof(sentence));
    
    Doc.data[pCount - 1].data[sCount - 1].word_count = 1;
    int wCount = Doc.data[pCount - 1].data[sCount - 1].word_count;
    Doc.data[pCount - 1].data[sCount - 1].data = (word*)malloc(sizeof(word));    
    
    int cCount = 1;
    Doc.data[pCount - 1].data[sCount - 1].data[wCount - 1].data = (char*)malloc(sizeof(char));
    
    int i = 0;
    while(text[i] != 0){      
        if (text[i] == '\n')
        {
            Doc.data[pCount - 1].data[sCount - 1].data[wCount - 1].data[cCount - 1] = 0;
            if (wCount == 1 && cCount == 1 && Doc.data[pCount - 1].data[sCount - 1].data[wCount - 1].data[cCount - 1] == 0)
            {
                Doc.data[pCount - 1].sentence_count--;
            }

            Doc.data = (paragraph*)realloc(Doc.data, (++pCount * sizeof(paragraph)));
            Doc.paragraph_count = pCount;
        
            Doc.data[pCount - 1].sentence_count = 1;
            sCount = Doc.data[pCount - 1].sentence_count;
            Doc.data[pCount - 1].data = (sentence*)malloc(sizeof(sentence));
    
            Doc.data[pCount - 1].data[sCount - 1].word_count = 1;
            wCount = Doc.data[pCount - 1].data[sCount - 1].word_count;
            Doc.data[pCount - 1].data[sCount - 1].data = (word*)malloc(sizeof(word));    

            Doc.data[pCount - 1].data[sCount - 1].data[wCount - 1].data = (char*)malloc(sizeof(char));
            cCount = 1;
        }
        else if (text[i] == '.')
        {
            Doc.data[pCount - 1].data[sCount - 1].data[wCount - 1].data[cCount - 1] = 0;
            
            Doc.data[pCount - 1].data = (sentence*)realloc(Doc.data[pCount - 1].data,  ++sCount * sizeof(sentence));
            Doc.data[pCount - 1].sentence_count = sCount;

            Doc.data[pCount - 1].data[sCount - 1].word_count = 1;
            wCount = Doc.data[pCount - 1].data[sCount - 1].word_count;
            Doc.data[pCount - 1].data[sCount - 1].data = (word*)malloc(sizeof(word));

            Doc.data[pCount - 1].data[sCount - 1].data[wCount - 1].data = (char*)calloc(1, sizeof(char));
            cCount = 1;
        } 
        else if (text[i] == ' ')
        {
            Doc.data[pCount - 1].data[sCount - 1].data[wCount - 1].data[cCount - 1] = 0;
            
            Doc.data[pCount - 1].data[sCount - 1].data = (word*)realloc(Doc.data[pCount - 1].data[sCount - 1].data , ++wCount * sizeof(word));
            Doc.data[pCount - 1].data[sCount - 1].word_count = wCount;
            Doc.data[pCount - 1].data[sCount - 1].data[wCount - 1].data = (char*)malloc(sizeof(char));
            cCount = 1;
        }
        else
        {
            Doc.data[pCount - 1].data[sCount - 1].data[wCount - 1].data[cCount - 1] = text[i];
            Doc.data[pCount - 1].data[sCount - 1].data[wCount - 1].data = (char*)realloc(Doc.data[pCount - 1].data[sCount - 1].data[wCount - 1].data, ++cCount * sizeof(char));
        }
        i++;
    }
    Doc.data[pCount - 1].data[sCount - 1].data[wCount - 1].data[cCount - 1] = 0;
    if (wCount == 1 && cCount == 1 && Doc.data[pCount - 1].data[sCount - 1].data[wCount - 1].data[cCount - 1] == 0)
    {
        Doc.data[pCount - 1].sentence_count--;
    }

    return Doc;
}

struct word kth_word_in_mth_sentence_of_nth_paragraph(struct document Doc, int k, int m, int n) {
    return Doc.data[n-1].data[m-1].data[k-1];
}

struct sentence kth_sentence_in_mth_paragraph(struct document Doc, int k, int m) { 
    return Doc.data[m-1].data[k-1];
}

struct paragraph kth_paragraph(struct document Doc, int k) {
    return Doc.data[k-1];
}

void print_word(struct word w) {
    printf("%s", w.data);
}

void print_sentence(struct sentence sen) {
    for(int i = 0; i < sen.word_count; i++) {
        print_word(sen.data[i]);
        if (i != sen.word_count - 1) {
            printf(" ");
        }
    }
}

void print_paragraph(struct paragraph para) {
    for(int i = 0; i < para.sentence_count; i++){
        print_sentence(para.data[i]);
        printf(".");
    }
}

void print_document(struct document doc) {
    for(int i = 0; i < doc.paragraph_count; i++) {
        print_paragraph(doc.data[i]);
        if (i != doc.paragraph_count - 1)
            printf("\n");
    }
}

char* get_input_text() {	
    int paragraph_count;
    scanf("%d", &paragraph_count);

    char p[MAX_PARAGRAPHS][MAX_CHARACTERS], doc[MAX_CHARACTERS];
    memset(doc, 0, sizeof(doc));
    getchar();
    for (int i = 0; i < paragraph_count; i++) {
        scanf("%[^\n]%*c", p[i]);
        strcat(doc, p[i]);
        if (i != paragraph_count - 1)
            strcat(doc, "\n");
    }

    char* returnDoc = (char*)malloc((strlen (doc)+1) * (sizeof(char)));
    strcpy(returnDoc, doc);
    return returnDoc;
}

int main() 
{
    char* text = get_input_text();
    struct document Doc = get_document(text);

    int q;
    scanf("%d", &q);

    while (q--) {
        int type;
        scanf("%d", &type);

        if (type == 3){
            int k, m, n;
            scanf("%d %d %d", &k, &m, &n);
            struct word w = kth_word_in_mth_sentence_of_nth_paragraph(Doc, k, m, n);
            print_word(w);
        }

        else if (type == 2) {
            int k, m;
            scanf("%d %d", &k, &m);
            struct sentence sen= kth_sentence_in_mth_paragraph(Doc, k, m);
            print_sentence(sen);
        }

        else{
            int k;
            scanf("%d", &k);
            struct paragraph para = kth_paragraph(Doc, k);
            print_paragraph(para);
        }
        printf("\n");
    }     
}