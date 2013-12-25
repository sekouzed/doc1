#include <stdio.h>
#include <unistd.h>

main(int argc, char *argv[]) {
execvp("nano",argv);
perror("erreur sur l'edition du fichier");
}
