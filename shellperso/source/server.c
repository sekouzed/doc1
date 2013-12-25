#include <stdio.h>
#include <stdlib.h>
#include <errno.h>
#include <string.h>
#include <sys/types.h>
#include <sys/socket.h>
#include <netinet/in.h>
#include <arpa/inet.h>
#include <unistd.h> /* close */
#include <netdb.h> /* gethostbyname */
#define INVALID_SOCKET -1
#define SOCKET_ERROR -1
#define closesocket(s) close(s)
typedef int SOCKET;
typedef struct sockaddr_in SOCKADDR_IN;
typedef struct sockaddr SOCKADDR;
typedef struct in_addr IN_ADDR;
#define CRLF		"\r\n"
#define PORT	 	1977
#define BUF_SIZE	1024

typedef struct
{
   SOCKET sock;
   char name[BUF_SIZE];
}Client;

int enLinge = 0;
static Client client;

static void enlever_client(Client *client)
{
   if(enLinge)
   {
      closesocket(client->sock);
   }
}

static void supprimer_client(Client *client)
{
   memmove(&client,&client + 1, 0);
   enLinge--;
}

static int connexion(void)
{
   SOCKET sock = socket(AF_INET, SOCK_STREAM, 0);
   SOCKADDR_IN sin = { 0 };
   if(sock == INVALID_SOCKET)
   {
      perror("socket()");
      exit(errno);
   }
   sin.sin_addr.s_addr = htonl(INADDR_ANY);
   sin.sin_port = htons(PORT);
   sin.sin_family = AF_INET;
   if(bind(sock,(SOCKADDR *) &sin, sizeof sin) == SOCKET_ERROR)
   {
      perror("bind()");
      exit(errno);
   }
   if(listen(sock,1) == SOCKET_ERROR)
   {
      perror("listen()");
      exit(errno);
   }
   return sock;
}

static void deconnexion(int sock)
{
   closesocket(sock);
}

static int lire(SOCKET sock, char *buffer)
{
   int n = 0;
   if((n = recv(sock, buffer, BUF_SIZE - 1, 0)) < 0)
   {
      perror("recv()");
      n = 0;
   }
   buffer[n] = 0;
   return n;
}

static void ecrire(SOCKET sock, const char *buffer)
{
   if(send(sock, buffer, strlen(buffer), 0) < 0)
   {
      perror("send()");
      exit(errno);
   }
}

void server(void)
{
   SOCKET sock = connexion();
   char buffer[BUF_SIZE];
   int max = sock;
   fd_set rdfs;
   while(1)
   {
      FD_ZERO(&rdfs);
      FD_SET(STDIN_FILENO, &rdfs);
      FD_SET(sock, &rdfs);
      if(enLinge)
      {
         FD_SET(client.sock, &rdfs);
      }
      if(select(max + 1, &rdfs,NULL, NULL, NULL) == -1)
      {
         perror("select()");
         exit(errno);
      }
    if(FD_ISSET(STDIN_FILENO, &rdfs))
      {
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
         if(enLinge && send(client.sock, buffer, strlen(buffer), 0) < 0)
	{
	  perror("send()");
	  exit(errno);
	  }
      }
      else if(FD_ISSET(sock, &rdfs))
      {
         SOCKADDR_IN csin = { 0 };
         size_t sinsize = sizeof csin;
         int csock = accept(sock, (SOCKADDR *)&csin, &sinsize);
         if(csock == SOCKET_ERROR)
         {
            perror("accept()");
            continue;
         }
         if(lire(csock, buffer) == -1)
         {
              continue;
         }
         max = csock > max ? csock : max;
         FD_SET(csock, &rdfs);
         Client c = { csock };
         strncpy(c.name, buffer, BUF_SIZE - 1);
	 client=c;
         enLinge=1;
	}
      else
      {
         if(enLinge)
         {
           if(FD_ISSET(client.sock, &rdfs))
            {
               int c = lire(client.sock, buffer);
               if(c == 0)
               {
                  closesocket(client.sock);
                  supprimer_client(&client);
		  puts("Client déconnecté");
               }
               else
               {
		  printf("%s : ",client.name);
                  puts(buffer);
               }
            }
         }
      }
   }

   enlever_client(&client);
   deconnexion(sock);
}

int main(int argc, char **argv)
{
   server();
   return EXIT_SUCCESS;
}
