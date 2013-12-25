#include <stdio.h>
#include <unistd.h>

void main(int argc,char *argv[]){
execvp("ls",argv);
perror("erreur sur lister");
}
