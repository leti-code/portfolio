<?php
    include 'conexion.php';

    $dni = $_POST["dni"];
    $nombre = $_POST["nombre"];
    $ape = $_POST["apellidos"];
    $cp = $_POST["cp"];
    $nota = $_POST["nota"];
    $e1 = $_POST["e1"];
    $e2 = $_POST["e2"];
    $e3 = $_POST["e3"];

    $sen = "insert into alumnos (dni, nombre, apellidos, cp, nota_media, empresa1, empresa2, empresa3) values ('$dni', '$nombre', '$ape', '$cp', '$nota', '$e1', '$e2', '$e3' );";

    mysqli_query($conexion, $sen) or die ("Problemas al lanzar el query: " . mysqli_error($conexion));

    mysqli_close($conexion);
?>
<script> 
   
   window.location.href= "./altaAlumnos.php";
   alert('Alumno registrado');
</script>