#include<stdio.h>
#include<stdlib.h>
#include<unistd.h> 
#include<sys/types.h> 
#include<sys/wait.h> 

typedef int Semaphore [2] ;
void Initsem(Semaphore S, int N);
void P(Semaphore S);
void V(Semaphore S);
void attente(int N);
void message(int i, char* s,int a);
void receptionniste(int);



/* initialiser le semaphore S */
void Initsem(Semaphore S, int N)
{
    int i;
    char c='a';
    pipe(S);
    for(i=1; i<=N; i++)write(S[1],&c,1);
}
/* P sur le semaphore S, prendre un jeton 'a' */
void P (Semaphore S)
{
    char c;
    read(S[0],&c,1);
}
/* V sur le semaphore S, remettre un jeton 'a' */
void V (Semaphore S)
{
    char c='a';
    write(S[1],&c,1);
}



