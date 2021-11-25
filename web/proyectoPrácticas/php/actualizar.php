<?php
    include 'conexion.php';

    $sen = "select dni, nota_media from alumnos";

    $registros = mysqli_query($conexion, $sen) 
    or die ("Problemas al recuperar" . mysqli_error($conexion));

    //Sacar el id del alumno y su nota
    $cont = 0;
    while($reg = mysqli_fetch_array($registros)){
        $alumnos[$cont]['dni'] = $reg['dni'];
        $alumnos[$cont]['nota'] = $reg['nota_media'];
        $cont++;
    }


    //Ordenar el array por nota (método burbuja)
    for($i = 0; $i< (count($alumnos) - 1); $i++){
        for($j = 1; $j < count($alumnos); $j++ ){
            if($alumnos[$j]['nota'] > $alumnos[$i]['nota'] ){
                $dni_aux = $alumnos[$j]['dni'];
                $nota_aux = $alumnos[$j]['nota'];
                $alumnos[$j]['dni'] = $alumnos[$i]['dni'];
                $alumnos[$i]['dni'] = $dni_aux;
                $alumnos[$j]['nota'] = $alumnos[$i]['nota'];
                $alumnos[$i]['nota'] = $nota_aux;
            }
        }
    }

    //Vaciar el dni_alumno de la tabla empresas
    $sen = "UPDATE `empresas` SET `dni_alumno`=NULL";
    mysqli_query($conexion, $sen) or die ("Problemas con el query" . mysqli_error($conexion));


    //Rellenar el dni_alumno en la tabla ordenado
    for($i = 0; $i< count($alumnos); $i++ ){
        //Coger las empresas que quiere cada alumno
        $query = "select dni, empresa1, empresa2, empresa3 from alumnos where dni='" . $alumnos[$i]['dni'] . "';";
        $getInfo = mysqli_query($conexion, $query ) or die("Problema con el query". mysqli_error($conexion));

        
        $infoAlumno = mysqli_fetch_array($getInfo);

        //Comprobar si la empresa está cogida y sino asignarsela
        $alumnoAsignado = "select dni_alumno from empresas where id=" . $infoAlumno['empresa1'];
        $registroDni = mysqli_query($conexion, $alumnoAsignado);
        $regDni = mysqli_fetch_array($registroDni);
        

        if($regDni['dni_alumno'] == null){
            //Insertar el dato del alumno
            $sen = "update empresas set dni_alumno ='". $infoAlumno['dni'] . "' where id=" . $infoAlumno['empresa1'];
            mysqli_query($conexion, $sen) or die("Problema al actualizar" . mysqli_error($conexion));
        }else{
            //Buscar la segunda opción

            $alumnoAsignado = "select dni_alumno from empresas where id=" . $infoAlumno['empresa2'];
            $registroDni = mysqli_query($conexion, $alumnoAsignado);
            $regDni = mysqli_fetch_array($registroDni);
            if($regDni['dni_alumno'] == null){
                //Insertar el dato del alumno
                $sen = "update empresas set dni_alumno ='". $infoAlumno['dni'] . "' where id=" . $infoAlumno['empresa2'];
                mysqli_query($conexion, $sen) or die("Problema al actualizar" . mysqli_error($conexion));
            }else{
                //Buscar la tercera opción
                $alumnoAsignado = "select dni_alumno from empresas where id=" . $infoAlumno['empresa3'];
                $registroDni = mysqli_query($conexion, $alumnoAsignado);
                 $regDni = mysqli_fetch_array($registroDni);
                if($regDni['dni_alumno'] == null){
                    //Insertar el dato del alumno
                    $sen = "update empresas set dni_alumno ='". $infoAlumno['dni'] . "' where id=" . $infoAlumno['empresa3'];
                    mysqli_query($conexion, $sen) or die("Problema al actualizar" . mysqli_error($conexion));
                }
            }
        }   
    }

    
?>
<script> 
   
   window.location.href= "./../index.html";
   alert('Base de datos actualizada');
</script>