#include <stdio.h>
#include <stdlib.h>
#include <unistd.h>
#include "get_next_line_bonus.h"

int main(){
	/*Ejemplo para probar el funcionamiento del get_next_line.
	Se han realizado algunas pruebas caseras para comprobar que el programa se comporta como debe*/
	char *cad = NULL;
	int salida;
	int fd = open("ejemplo.txt", O_RDONLY);
	int fd2, fd3;


	if (fd == -1){
		printf("fallo al abrir");
		exit(1);
	}
	//salida = 1;
	printf("------BUCLE PARA RECORRER TODO UN ARCHIVO-----\n");
	while ((salida = get_next_line(fd, &cad)) == 1)
	{
		printf("SALIDA: %d ****LINE --->%s<---\n\n",salida,  cad);
		free (cad);
	}
	printf("ULTIMA SALIDA: %d ****LINE --->%s<---\n",salida,  cad);
	free(cad);	
	close(fd);

	printf("\n\n");
	printf("------METER UN FD NO VÁLIDO COMO 42-----\n");
	salida = get_next_line(42,&cad);
	printf("SALIDA: %d ****LINE --->%s<---\n",salida,  cad);
	//free(cad);

	printf("\n\n");


	

	printf("\n\n");
	printf("\n\n");
	printf("          -----------------------------------------\n");
	printf("          -----------------------------------------\n");
	printf("          --------------VARIOS ARCHIVOS------------\n");
	printf("          -----------------------------------------\n");
	
	printf("\n\n");
	printf("\n\n");
	fd = open("ejemplo2.txt", O_RDONLY);
	fd2 = open("ejemplo3", O_RDONLY);
	fd3 = open("ejemplo4.txt", O_RDONLY);
	salida = get_next_line(fd,&cad);
	printf("fd-linea1**SALIDA: %d ***LINEA --->%s<---\n",salida,  cad);
	free(cad);
	salida = get_next_line(fd2,&cad);
	printf("fd2-linea1**SALIDA: %d ****ULTIMA --->%s<---\n",salida,  cad);
	free(cad);
	salida = get_next_line(fd,&cad);
	printf("fd-linea2**SALIDA: %d ***LINEA --->%s<---\n",salida,  cad);
	free(cad);
	salida = get_next_line(fd3,&cad);
	printf("fd3-linea1**SALIDA: %d ***LINEA --->%s<---\n",salida,  cad);
	free(cad);
	salida = get_next_line(fd3,&cad);
	printf("fd3-linea2**SALIDA: %d ****ULTIMA --->%s<---\n",salida,  cad);
	free(cad);
	salida = get_next_line(fd,&cad);
	printf("fd-linea2**SALIDA: %d ****ULTIMA --->%s<---\n",salida,  cad);
	free(cad);

	close(fd);
	close(fd2);
	close(fd3);
}
