<!doctype html>
<html lang="en">
  <head>
    <!-- Required meta tags -->
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <link rel="shortcut icon" href="../img/oZKaN5aJ_400x400.jpg">

    <!-- Bootstrap CSS -->
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3" crossorigin="anonymous">

    <title>Alta de datos de alumnos</title>
    <style>
        .mb-3, .btn  {margin: 40px;}
        a {text-decoration: none; color: white;}
        a:hover{color:white;}
        h1 {margin: 30px;}
        .companies {margin: 30px; border: 2px solid black;}
        td{ padding: 7px; border: 1px solid black;}
    </style>
  </head>
  <body>
    <h1>Insertar datos del alumno</h1>

    <!-- Option 1: Bootstrap Bundle with Popper -->
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.min.js" integrity="sha384-ka7Sk0Gln4gmtz2MlQnikT1wXgYsOg+OMhuP+IlRH9sENBO0LRn5q+8nbTov4+1p" crossorigin="anonymous"></script>

    <form action="./darAltaAlumno.php" method="post">
        <!--Introducción de DNI-->
        <div class="mb-3">
          <label for="dni" class="form-label">Introduzca el DNI del alumno</label>
          <input type="text" class="form-control" id="dni" name="dni">
        </div>
        <!--Fin-->

        <!--Introducción de nombre-->
        <div class="mb-3">
            <label for="nombre" class="form-label">Introduzca el nombre</label>
            <input type="text" class="form-control" id="nombre" name="nombre">
          </div>
        <!--Fin-->

        <!--Introducción de apellidos-->
          <div class="mb-3">
            <label for="apellidos" class="form-label">Introduzca los apellidos</label>
            <input type="text" class="form-control" id="apellidos" name="apellidos">
          </div>
        <!--Fin-->

        <!--Introducción de cp-->
          <div class="mb-3">
            <label for="cp" class="form-label">Introduzca el código postal</label>
            <input type="text" class="form-control" id="cp" name ="cp">
          </div>
        <!--Fin-->

        <!--Introducción de nota_media-->
        <div class="mb-3">
            <label for="nota" class="form-label">Introduzca la nota media del alumno</label>
            <input type="text" class="form-control" id="nota" name ="nota">
        </div>
        <!--Fin-->

        <div class="mb-3">Aquí tiene la tabla de las empresas registradas actualmente: </div>
        <?php
            include 'conexion.php';

            $registros = mysqli_query($conexion, "select * from empresas") 
            or die("Problemas al recuperar" . mysqli_error($conexion));

            echo "
            <table class='companies'>
                <tr>
                    <th>Código</th>
                    <th>Nombre</th>
                    <th>Teléfono</th>
                    <th>Cód. postal</th>
                </tr>";

            while($reg = mysqli_fetch_array($registros)){
                echo "
                <tr>
                    <td>" . $reg['ID'] . "</td>
                    <td>" . $reg['nombre'] . "</td>
                    <td>" .  $reg['telefono'] . "</td>
                    <td>" . $reg['cp'] . "</td>
                </tr>    
            ";
            }
            echo "</table>";
            mysqli_close($conexion);
        ?>

        <!--Select de las empresas disponibles-->

        <div class="mb-3">
        <select id="e1" name="e1">
          <option value="" selected="selected">- Selecciona primera opción 
          -</option>
          <?php
            include 'conexion.php';

            $registros = mysqli_query($conexion, "select * from empresas") 
            or die("Problemas al recuperar" . mysqli_error($conexion));

            while($reg = mysqli_fetch_array($registros)){
              echo "<option value='" . $reg['ID'] . "'>" . $reg['ID'] . "-" . $reg['nombre']. "</option>";
            }

            mysqli_close($conexion);

          ?>
          </select>
          </div>

          <div class="mb-3">
        <select id="e2" name="e2">
          <option value="" selected="selected">- Selecciona segunda opción 
          -</option>
          <?php
            include 'conexion.php';

            $registros = mysqli_query($conexion, "select * from empresas") 
            or die("Problemas al recuperar" . mysqli_error($conexion));

            while($reg = mysqli_fetch_array($registros)){
              echo "<option value='" . $reg['ID'] . "'>" . $reg['ID'] . "-" . $reg['nombre']. "</option>";
            }

            mysqli_close($conexion);

          ?>
          </select>
          </div>

          <div class="mb-3">
        <select id="e3" name="e3">
          <option value="" selected="selected">- Selecciona tercera opción 
          -</option>
          <?php
            include 'conexion.php';

            $registros = mysqli_query($conexion, "select * from empresas") 
            or die("Problemas al recuperar" . mysqli_error($conexion));

            while($reg = mysqli_fetch_array($registros)){
              echo "<option value='" . $reg['ID'] . "'>" . $reg['ID'] . "-" . $reg['nombre']. "</option>";
            }

            mysqli_close($conexion);

          ?>
          </select>
          </div>

          <div class="mb-3">
        <select id="e4" name="e4">
          <option value="" selected="selected">- Selecciona cuarta opción 
          -</option>
          <?php
            include 'conexion.php';

            $registros = mysqli_query($conexion, "select * from empresas") 
            or die("Problemas al recuperar" . mysqli_error($conexion));

            while($reg = mysqli_fetch_array($registros)){
              echo "<option value='" . $reg['ID'] . "'>" . $reg['ID'] . "-" . $reg['nombre']. "</option>";
            }

            mysqli_close($conexion);

          ?>
          </select>
          </div>

          <div class="mb-3">
        <select id="e5" name="e5">
          <option value="" selected="selected">- Selecciona quinta opción 
          -</option>
          <?php
            include 'conexion.php';

            $registros = mysqli_query($conexion, "select * from empresas") 
            or die("Problemas al recuperar" . mysqli_error($conexion));

            while($reg = mysqli_fetch_array($registros)){
              echo "<option value='" . $reg['ID'] . "'>" . $reg['ID'] . "-" . $reg['nombre']. "</option>";
            }

            mysqli_close($conexion);

          ?>
          </select>
          </div>
        <!--Fin-->

        <!--Mejora: Posibilidad de que si ya ha marcado una empresa 
        no pueda marcarla en las otras opciones-->
        
        <input type="submit" class="btn btn-primary" value="Enviar"/>
        <button  class="btn btn-primary"><a href="./../index.html">Volver a página de inicio</a></button>

      </form>
  </body>
</html>

