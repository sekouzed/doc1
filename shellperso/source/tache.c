#include <stdio.h>
#include <unistd.h>

void main(int argc,char *argv[]){
execvp("ps",argv);
perror("erreur sur la copie");
}
