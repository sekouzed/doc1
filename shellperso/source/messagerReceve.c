#include <errno.h>
#include <stdio.h>
#include <stdlib.h>
#include <stdio.h>
#include <signal.h>
#include <sys/types.h>
#include <sys/ipc.h>
#include <sys/msg.h>
#include <unistd.h>

#define MAXTEXTE 1000
struct tampon {
  long mpid;
  char mtext[MAXTEXTE];
};

int clef_interne;

int main(int argc,char *argv[])
{
  int clef_externe;
  struct sigaction a;

  if (argc!=2) {
    fprintf(stderr,"Usage: %s clef_externe\n", argv[0]);
    exit(1);
  };

  //if (fork()==0) execlp("clear","clear",NULL);
 // wait();
printf("\n*****bEnvEnuE dans la boite de reception du messager****\n");
printf("votre PID=%d, Clef externe=%s\nAttente de reception...",getpid(),argv[1]);
  clef_externe = atoi(argv[1]);
  clef_interne  = msgget (clef_externe,IPC_CREAT | 0666);
  if (clef_interne == -1)
  {
perror("Echec d'ouverture du messagerReceve");
    exit(EXIT_FAILURE);
  };

    int l;
    struct tampon msg;
    l = msgrcv(clef_interne,(struct msgbuf *)&msg,MAXTEXTE,0L,0);
    if(l == -1)
    {
      perror("Echec d'ouverture de reception");
      exit(EXIT_FAILURE);
    };
    printf("\n***Nouveau message en provenance du pid=%ld\nMessage: %s\n",msg.mpid,msg.mtext);
}
