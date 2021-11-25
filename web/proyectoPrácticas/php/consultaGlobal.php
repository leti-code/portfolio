<?php
    include 'conexion.php';

    $sen = "select empresas.nombre, dni_alumno, concat(alumnos.nombre, ' ', alumnos.apellidos) as alumno from alumnos, empresas where dni_alumno = dni;";

    $registros = mysqli_query($conexion, $sen) or die ("Problemas al recuperar" . mysqli_error($conexion));

?>
<html>
    <head>
        <!-- Required meta tags -->
        <meta charset="utf-8">
        <meta name="viewport" content="width=device-width, initial-scale=1">
        <link rel="shortcut icon" href="../img/oZKaN5aJ_400x400.jpg">

        <!-- Bootstrap CSS -->
        <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3" crossorigin="anonymous">

        <title>Registro de prácticas</title>
        <style>
        h2 {margin: 30px;}
        .mb-3 {margin: 40px;}
        .btn{margin-left: 350px;}
        a {text-decoration: none; color: white;}
        a:hover{color:white;}
        .relation {margin: 30px; border: 2px solid black;}
        td{ padding: 7px; border: 1px solid black;}
        th{padding: 10px;}

    </style>
  </head>
  <body>
    <h2 class="mb-3">Tabla relación empresas-alumnos:</h2>
    <div class="mb-3">
        <table class="relation">
            <tr class="btn-primary">
                <th>Empresa</th>
                <th>Alumno</th>
                <th>DNI alumno</th>
            </tr>
            <?php
                while($reg = mysqli_fetch_array($registros)){
                    echo "
                        <tr>
                            <td>" . $reg['nombre'] . "</td>
                            <td>" . $reg['alumno'] . "</td>
                            <td>" .  $reg['dni_alumno'] . "</td>
                        </tr>    
                    ";
                }
                mysqli_close($conexion);
            ?>
        </table>
    </div>

    <div class="mb-3 btn btn-primary">
        <p><a href="./../index.html">Volver a página de inicio</a></p>
    </div>

  </body>
</html>
