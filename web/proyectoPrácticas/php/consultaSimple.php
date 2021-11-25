<!doctype html>
<html lang="en">
  <head>
    <!-- Required meta tags -->
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <link rel="shortcut icon" href="../img/oZKaN5aJ_400x400.jpg">

    <!-- Bootstrap CSS -->
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3" crossorigin="anonymous">

    <title>Datos empresa</title>
    <style>
        .mb-3 {margin: 40px;}
        .btn{margin-left: 350px;}
        a {text-decoration: none; color: white;}
        a:hover{color:white;}
        h1, .error {margin: 40px;}
    </style>
  </head>
  <body>
    <h1>Datos de la empresa</h1>


    <!-- Option 1: Bootstrap Bundle with Popper -->
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.min.js" integrity="sha384-ka7Sk0Gln4gmtz2MlQnikT1wXgYsOg+OMhuP+IlRH9sENBO0LRn5q+8nbTov4+1p" crossorigin="anonymous"></script>

    <?php
    include 'conexion.php';
    //Conexión con la bbdd

    $codigo = $_GET["codigo"];
    $sen = "select empresas.nombre, empresas.telefono, empresas.cp, dni_alumno, concat(alumnos.nombre, ' ', alumnos.apellidos) as alumno from empresas, alumnos where ID=" . $codigo . " and dni_alumno = dni" ;
    $registro = mysqli_query($conexion, $sen) or die("Problemas conectando con la base de datos" . mysqli_error($conexion));
    if($reg = mysqli_fetch_array($registro)){
        $nombre = $reg['nombre'];
        $tlf = $reg['telefono'];
        $cp = $reg['cp'];
        $alumno = $reg['alumno'];
        $dni = $reg['dni_alumno'];

    ?>
            <div class="mb-3">
                <h4>ID: <small class="text-muted"><?php echo $codigo ?></small></h3>
                <h4>Nombre empresa: <small class="text-muted"><?php echo $nombre ?></small></h3>
                <h4>Teléfono de la empresa: <small class="text-muted"><?php echo $tlf ?></small></h3>
                <h4>Código postal de la empresa: <small class="text-muted"><?php echo $cp ?></small></h3>
                <h4>Alumno asignado: <small class="text-muted"><?php echo $alumno ?></small></h3>
                <h4>DNI del alumno asignado: <small class="text-muted"><?php echo $dni ?></small></h3>
            </div>

        <div class="mb-3 btn btn-primary">
            <p><a href="./../index.html">Volver a página de inicio</a></p>
        </div>
        <br/>
        <div class="mb-3 btn btn-primary">
            <p><a href="./../html/consultaEmpresa.html">Buscar datos de otra empresa</a></p>
        </div>
          
    <?php
    }else{
        echo "<p class='error'>Empresa no encontrada o sin alumno asignado</p><br/>";
        echo "
        <div class='mb-3 btn btn-primary'>
            <a href='../html/consultaEmpresa.html'>Pulse este enlace para volver a buscar una empresa</a>
        </div><br/>";
        echo "
        <div class='mb-3 btn btn-primary'>
            <a href='../index.html'>Pulse este enlace para volver al inicio</a>
        </div>";

    };

    mysqli_close($conexion);
?>



  </body>
</html>




