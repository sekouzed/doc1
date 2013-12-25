#include <stdio.h>
#include <unistd.h>

void main(int argc,char *argv[]){
execvp("grep",argv);
perror("erreur sur touver");
}
