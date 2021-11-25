#include <stdio.h>

int main(){
	//int x = 8;
	//:w
	//int y = 2;
	double d = 12345.6789;
	printf("%020.3f\n", d);
	printf("%20.3f\n", d);
	printf("%-20.3f\n", d);
	//Si hay un - cuidado que si después hay un 0 no compila
	printf("%+020.3f\n", d);
	printf("% 020.3f\n", d);
	printf("con punto sin numero% 020.f\n", d);
	printf("con punto sin numero:% 020.00f\n", d);
	//si hay un + después no puede aparecer espacio en blanco, no compila
	printf("un numero hexadecimal -> %x\n", 0xaf);
	printf("un numero hexadecimal -> %x\n", 077);
	printf("fallo de que no haya tipo de dato %+05.a\n");

	printf("prueba para pasar porcentaje despues de flags%-010%\n");

	
}
