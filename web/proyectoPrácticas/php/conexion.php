<?php
    /*Para establecer la conexión con una base de datos se necesita:
     - Función mysqli_connect: cuyos parámetros serán
        -localhost: dominio por el que se conecta la base de datos, sea local o remota
        -usuario
        -contraseña del usuario
        -nombre base de datos*/
        $servername = "localhost";
        $username = "";
        $password = "";
        $database = "";

    $conexion = mysqli_connect($servername, $username, $password, $database) 
    or die("Problemas de conexión con la base de datos");
?>