/* ************************************************************************** */
/*                                                                            */
/*                                                        :::      ::::::::   */
/*   main.c                                             :+:      :+:    :+:   */
/*                                                    +:+ +:+         +:+     */
/*   By: lcasabel <marvin@42.fr>                    +#+  +:+       +#+        */
/*                                                +#+#+#+#+#+   +#+           */
/*   Created: 2021/03/19 11:46:22 by lcasabel          #+#    #+#             */
/*   Updated: 2021/04/12 10:11:58 by lcasabel         ###   ########.fr       */
/*                                                                            */
/* ************************************************************************** */

#include <stdio.h>
#include <unistd.h>
#include <stdlib.h>
#include "ft_printf.h"

int main(){
	/*Programa para realizar pruebas comparativas de funcionamiento entre el printf original y el propio*/

	int		hexa = 0xabc;
	int 	numero = 243;
	int 	num_negativo = -235;
	char 	caracter = 'x';
	char 	*cadena;

	cadena = "hola";
	
	ft_printf("--------------PROPIO------------\n");
	ft_printf("Esto es una cadena con salto de linea y sin variables \n");
	ft_printf("Esto es una cadena con variable cadena ->%s<-\n", cadena);
	ft_printf("Esto es una cadena con número decimal ->%d<- y hexadecimal ->%x<-\n", numero, numero);
	ft_printf("Esto es una cadena con número decimal negativo ->%d<- \n", num_negativo);
	ft_printf("Esto es un número con relleno->%010.0d<- y cadena recortada ->%2.s<-\n", numero, cadena);
	ft_printf("Imprimo un porcentaje ->F:|| |%%|<- y hexadecimal con x y X ->%x<-->%X<-\n", hexa, hexa);

	printf("\n\n");

	printf("-------------ORIGINAL-----------\n");
	printf("Esto es una cadena con salto de linea y sin variables \n");
	printf("Esto es una cadena con variable cadena ->%s<-\n", cadena);
	printf("Esto es una cadena con número decimal ->%d<- y hexadecimal ->%x<-\n", numero, numero);
	printf("Esto es una cadena con número decimal negativo ->%d<- \n", num_negativo);
	printf("Esto es un número con relleno->%010.0d<- y cadena recortada ->%2.s<-\n", numero, cadena);
	printf("Imprimo un porcentaje ->F:|| |%%|<- y hexadecimal con x y X ->%x<-->%X<-\n", hexa, hexa);

	printf("\n\n");

}
