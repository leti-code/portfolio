<?php
    include 'conexion.php';

    $nombre = $_POST["nombre"];
    $tlf = $_POST["telefono"];
    $cp = $_POST["cp"];

    $sen = "insert into empresas (nombre, telefono, cp) values ('$nombre', '$tlf', '$cp');";

    mysqli_query($conexion, $sen) or die ("Problemas al lanzar el query: " . mysqli_error($conexion));

    mysqli_close($conexion);
?>
<script> 
   
    window.location.href= "./../html/altaEmpresas.html";
    alert('Empresa registrada');
</script>