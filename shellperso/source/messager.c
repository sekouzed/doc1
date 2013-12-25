#include<stdio.h>
#include<sys/msg.h>
#include<unistd.h>
#include<time.h>
#include<stdlib.h>


main()
{
key_t cle;
int num_int;

typedef struct
{
long mtype;
char mtext[256];
}MESSAGE;
MESSAGE message;
#define LGMES sizeof(message.mtext)

/* creation d une file de message */
printf("Introduire une cle pour le messager: ");
    //fflush(stdout);
scanf("%d",&cle);
num_int=msgget(cle,IPC_CREAT | 0666);
if(num_int==-1)
{
perror("Echec d'ouverture du messager");
exit(1);
}

printf("\n*****bEnvEnuE dans le messager****\n");
printf("votre PID=%d, Clef externe=%d, Clef interne=%d",getpid(),cle,num_int);
printf("\n----------\n");


/* Envoi d un message */

printf("Numero de PID destinataire:");
scanf("%ld",&message.mtype);
printf("Votre message:");
scanf("%s",message.mtext);
printf("le messag est : %s\n",message.mtext);
if(msgsnd(num_int,&message,LGMES,IPC_NOWAIT)==-1)
{
perror("erreur msgsnd");
exit(1);
}
}
