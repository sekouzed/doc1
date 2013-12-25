#include<stdio.h>
#include<unistd.h>
#include<time.h>
#include<string.h>
#include<signal.h>
#include<stdlib.h>
#include<fcntl.h>
#include<sys/stat.h>
#include <ctype.h>    
#include <string.h>
#include <errno.h>       

char commandeTaper[4096];    
#define max 32
char* Aexecuter[max];
char* Arg1[max];
char* Arg2[max];
int nombreArgument=0;



void gedit(int sig)
{
  if (fork()==0)   {
execlp("gedit","gedit","test.txt",NULL);
	perror("erreur sur zshell"); 
}//wait();
}
void music(int sig)
{
  if (fork()==0)   {
 execlp("vlc","vlc","laseine.mp3", NULL);
	perror("erreur sur zshell");
}//wait();
}

void web(int sig)
{
  if (fork()==0)   {
 execlp("firefox","firefox","www.google.com",NULL);
	perror("erreur sur zshell");
}//wait();
}

void exeTube(){
	int p[2];

	if(pipe(p)==-1)
	{
	 perror("tube non cree");
	 exit(1);
	}
	 /* fils */

	if(fork()==0)
	{
	 dup2(p[1],1);/* sorti standard = tube */
	 close(p[0]);
	close(p[1]);
	    execvp(Arg1[0], Arg1  );
	 perror("tube non executer(1)");
	    _exit(1);
	}        
	 /* pere */
	dup2(p[0],0); /* entree standard = tube */
	close(p[0]);
	close(p[1]); 
	    execvp(Arg2[0], Arg2  );
	 perror("tube non executer(2)");
	exit(1);

}


void exeFifo()
{
    int R;

    R=mknod("fifo", S_IFIFO | 0666, 0);
    if(R==-1 && errno!=EEXIST)
    {
        perror("Echec de la creation du tube nommé");
        _exit(2);
    }
   
    int p=open("fifo",O_WRONLY, 0);
    if(p==-1)
    {
        perror("Echec d'ouverture du tube nommé");
        _exit(2);
    }
    dup2(p,1);
    
    execvp(Arg1[0], Arg1  );
    perror("Execution  echouée");
    _exit(1);
}

void execution()
{
   
//signal(SIGINT,gedit); /* Ctrl - C : signal 2 */
//signal(SIGTSTP,music); /* Ctrl - Z : signal 20 */
//signal(SIGQUIT,web); /* Ctrl - \ : signal 3 */
 
if(!Aexecuter[0]) return;
  

int i,j,k=0;
for(i=0;i<nombreArgument;i++)
{
	if(strcmp(Aexecuter[i],"tube")==0)//si ya un tube
	{
		for(j=i+1;j<nombreArgument;j++){
			Arg2[k]	=Aexecuter[j];k++;
		}

		if (fork()==0) exeTube();
		wait();return;
	}

	if(strcmp(Aexecuter[i],"fifo")==0)//si ya un fifo
	{
		if (fork()==0) exeFifo();
		 wait();return;
	}

	Arg1[i]	=Aexecuter[i];

}

//si ya pa tune ni fifo
  if (fork()==0)
   {
	    execvp(Arg1[0], Arg1  );
	    perror("Execution  echouée");
	    _exit(1);
   }
   wait();

  
}

void preparerLigneDeCommande()
{
  char* p = commandeTaper;
  for (nombreArgument=0; nombreArgument<max-1; nombreArgument++) {

    /* saute les espaces */
    while (*p && isspace(*p)) p++;

    /* fin de ligne ? */
    if (!*p) break;

    /* on se souvient du debut de ce mot */
    Aexecuter[nombreArgument] = p;

    /* cherche la fin du mot */
    while (*p && !isspace(*p)) p++; /* saute le mot */

    /* termine le mot par un \0 et passe au suivant */
    if (*p) { *p = 0; p++; }
  }

  Aexecuter[nombreArgument] = NULL;
}
//----------------------------programme principal------------------------------------

int main()
{
  if (fork()==0) execlp("clear","clear",NULL);
  wait();
  printf("\n    réalisé  par SEKOU DIOUBATE ");
  printf("\n------------------------------------");
  printf("\n|   BIENVENUE DANS MON MINISHELL   |");
  printf("\n------------------------------------\n\n");

  while (1) 
  {
    printf(":::SHELLPERSO:::$ ");
    fflush(stdout);
    if (!fgets(commandeTaper,sizeof(commandeTaper)-1,stdin)) {
       printf("\n");
       exit(0);
     }

    preparerLigneDeCommande();
    execution();

	int i;
	for(i=0;i<max;i++)
	{
		Aexecuter[i]=NULL;Arg1[i]=NULL;Arg2[i]=NULL;
	}
  }
  return 0;
}
