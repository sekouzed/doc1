#include <stdio.h>
#include <stdlib.h>
#include <errno.h>
#include <string.h>
#include <sys/types.h>
#include <sys/socket.h>
#include <netinet/in.h>
#include <arpa/inet.h>
#include <unistd.h> 
#include <netdb.h> 
#define INVALID_SOCKET -1
#define SOCKET_ERROR -1
#define closesocket(s) close(s)
typedef int SOCKET;
typedef struct sockaddr_in SOCKADDR_IN;
typedef struct sockaddr SOCKADDR;
typedef struct in_addr IN_ADDR;
#define CRLF "\r\n"
#define PORT 1977
#define BUF_SIZE 1024

int connexion(const char *address)
{
   SOCKET sock = socket(AF_INET, SOCK_STREAM, 0);
   SOCKADDR_IN sin = { 0 };
   struct hostent *hostinfo;
   if(sock == INVALID_SOCKET)
   {
      perror("socket()");
      exit(errno);
   }
   hostinfo = gethostbyname(address);
   if (hostinfo == NULL)
   {
      fprintf (stderr, "Unknown host %s.\n", address);
      exit(EXIT_FAILURE);
   }
   sin.sin_addr = *(IN_ADDR *) hostinfo->h_addr;
   sin.sin_port = htons(PORT);
   sin.sin_family = AF_INET;
   if(connect(sock,(SOCKADDR *) &sin, sizeof(SOCKADDR)) == SOCKET_ERROR)
   {
      perror("connect()");
      exit(errno);
   }
   return sock;
}

void deconnexion(int sock)
{
   closesocket(sock);
}
int lire(SOCKET sock, char *buffer)
{
   int n = 0;
   if((n = recv(sock, buffer, BUF_SIZE - 1, 0)) < 0)
   {
      perror("recv()");
      exit(errno);
   }
   buffer[n] = '\0';
   return n;
}
void ecrire(SOCKET sock, const char *buffer)
{
   if(send(sock, buffer, strlen(buffer), 0) < 0)
   {
      perror("send()");
      exit(errno);
   }
}

void client(const char *address, const char *name)
{
   SOCKET sock = connexion(address);
   char buffer[BUF_SIZE];
   fd_set rdfs;
   ecrire(sock, name);
   while(1)
   {
      FD_ZERO(&rdfs);
      FD_SET(STDIN_FILENO, &rdfs);
      FD_SET(sock, &rdfs);
      if(select(sock + 1, &rdfs, NULL, NULL, NULL) == -1)
      {
         perror("select()");
         exit(errno);
      }
      if(FD_ISSET(STDIN_FILENO, &rdfs))
      {

         printf("votre message: ");
         fgets(buffer, BUF_SIZE - 1, stdin);
         {
            char *p = NULL;
            p = strstr(buffer, "\n");
            if(p != NULL)
            {
               *p = 0;
            }
            else
            {
               buffer[BUF_SIZE - 1] = 0;
            }
         }
         ecrire(sock, buffer);
      }
      else if(FD_ISSET(sock, &rdfs))
      {
         int n = lire(sock, buffer);
         if(n == 0)
         {
            printf("\nle Server est deconnecté !\n");
            break;
         }
	 printf("\nServer: ");
         puts(buffer);
      }
   }
   deconnexion(sock);
}

int main(int argc, char **argv)
{
   if(argc < 2)
   {
      printf("Systhaxe : %s [address] [pseudo]\n", argv[0]);
      return EXIT_FAILURE;
   }
   client("localhost", argv[1]);
   return EXIT_SUCCESS;
}
