#include "semaphore.h"

void message(int i, char* s,int a)
{
    #define colonne 20
    int Nb, j ;
    Nb=(i-1)*colonne;
    for(j=0; j<Nb; j++) putchar(' ');
    printf("%s%d\n" ,s,a);
    fflush(stdout);
}

static int temp=0;
static int debut=0;
Semaphore S;

void processus(int num)
{
    if(fork()==0)
    {  
        P(S); 
        debut=temp;

        message(num,"Pret a lire.. ",num);
        int delai=rand() % 6;
        sleep(delai);
        temp += delai;
        message(num,"..lecture... ",num);
        int duree= rand() % 6;
        sleep(duree);
        temp+=duree;
        
	message(num,"Fini de lire en ",temp-debut);
       
	if(temp==20){P(S);kill(getpid(),SIGTSTP);}

         
        V(S);
int proc=rand() % 3;
processus(proc+1);
    }
}

main()
{
   
    printf("\nApplicaion de semaphore:\n");
    printf("\nOn trois processus qui veullent acceder un fichier en meme temp\n");
    printf("\nMais un processus peut lire le fichier a un instant\n");
    printf("\n---------------------------------------------------------------\n");
    printf("\n%s%20s%20s\n","processus 1","processus 2","processus 3");
    Initsem(S,1);
    processus(1);

    
    int i ;
    for(i=1; i<=3; i++) wait(0);
}
