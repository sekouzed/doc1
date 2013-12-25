#include <stdio.h>
#include <unistd.h>

main() {

	execlp("clear","clear",NULL);
	perror("erreur sur vider");
}
