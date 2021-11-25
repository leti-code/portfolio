# Proyectos en C

Antes de comenzar es importante que tenga instalado algún compilador de programas en lenguaje C ya que este lenguaje requiere de una compilación previa a la ejecución del programa. 
En este caso vamos a trabajar con gcc aunque existen también otros compiladores así como compiladores en línea.

Un buen tutorial explicativo sobre cómo instalar el compilador de c y c++ en Windows, que nos permite además añadir la extensión de compilación a Visual Studio Code, uno de los editores más utilizados en programación:
https://code.visualstudio.com/docs/cpp/config-mingw


## GetNextLine
Este proyecto pretende crear una función que sea capaz de leer una línea de un archivo.
Para realizar esta funcionalidad no se permitió el uso de funciones predeterminadas de c como printf, split, etc.

Incluye un método main (donde sí aparece la función printf) donde se realizan algunas pruebas con algunos archivos de ejemplo

Para poder ejecutar la prueba con el método main es necesario compilarlo primero (estando situado dentro del directorio 'GetNextLine'):
 ```gcc .\main.c .\get_next_line_bonus.c .\get_next_line_utils_bonus.c -o ejecutable```

Tras eso puede ejecutar el programa escribiendo en la línea de comandos ```./ejecutable.exe```

## Printf
Este proyecto pretende replicar el funcionamiento del printf, que es la función usada en c para imprimir por consola cadenas de caracteres
Al igual que en el GetNextLine sólo se permitió el uso de funciones creadas por nosotros mismos que están recogidos en una librerría propia llamada Libft donde se pueden encontrar una serie de funciones auxiliares (no todas usadas en este proyecto).

Incluye también un método main donde se realizan algunas pruebas comparando el funcionamiento del ft_printf y del printf original
Para poder ejecutar la prueba, primero es necesario compilar la función con todas sus dependencias. Para facilitar esta tarea se ha creado un archivo Makefile, siguiendo estos pasos (estando situado dentro del directorio 'Printf'):
```make```
A continuación ejecutar el main con el la librería estática creada con el Makefile:
```gcc main.c libftprintf.a -o ejecutable```
Ejecutar el programa:
```./ejecutable.exe```
Es recomendable, para finalizar ejecutar ```make fclean``` en la consola de comandos que borrará los archivos intermedios creados y la librería.
