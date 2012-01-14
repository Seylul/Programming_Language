#include <stdio.h>
char s[]="kavak";
int c=0;
void polindrome(char *s) {
    char *p = s;

    while(*s)
    
        s++;
    for (s--; s>p; s--, p++) {
        if (*s != *p){
			printf("bu bir polindrom degil");
			c=+1;
			break;
		}
		}
	if (c==0)
		printf("bu bir polindrom");
    }
int main (){
	
	polindrome(s);
	
	return 0;
	}

