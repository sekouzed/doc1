#include <stdio.h>
#include <unistd.h>

void main(int argc,char *argv[]){
execvp("cp",argv);
perror("erreur sur la copie");
}
