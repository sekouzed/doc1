#include <stdio.h>
#include <unistd.h>
#include <string.h>

main(int argc, char *argv[]) {
		execlp("pwd","pwd",NULL);
		perror("erreur sur repcourant");
	}
