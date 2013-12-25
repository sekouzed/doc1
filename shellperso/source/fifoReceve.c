#include <stdio.h>
#include <sys/stat.h>
#include <errno.h>
#include <fcntl.h>
#include <unistd.h>

main()
{
   
  int p=open("fifo", O_RDONLY, 0);
    
  if(p==-1)
    {
        perror("Echec d'ouverture du tube nommé");
        _exit(2);
    }

    dup2(p,0);
    int c;
    while((c=getchar())!=EOF) putchar(c);
}
