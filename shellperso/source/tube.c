#include<stdio.h>
#include<unistd.h>
#include<wait.h>
#include<stdlib.h>


main(int argc, char *argv[]) {
/*
if (argc < 4){
	printf("\nCommande in correct\n");
 exit(1);
}
*/

int p[2];

if(pipe(p)==-1)
{
 perror("tube non cree");
 exit(1);
}
 /* fils */

if(fork()==0)
{
 dup2(p[1],1);
 close(p[0]);
close(p[1]);
execlp(argv[1],argv[1],NULL);
//  execlp("ls","ls",NULL);
 perror("tube non executer(1)");
 exit(1);
}
//  wait();           
 /* pere */
dup2(p[0],0); /* entree standard = tube */
close(p[0]);/* p[0] est devenu inutil */
close(p[1]); /* le pere n’ecrit pas dans le tube */
execlp(argv[3],argv[3],NULL);
 // execlp("wc","wc",NULL);
 perror("tube non executer(2)");
exit(1);

}
 

