package com.example.examenactivities;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.RadioButton;
import android.widget.Toast;

import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class Registro extends AppCompatActivity {

    //Variables que enlazaremos con los elementos gráficos de la ventana
    private EditText nom, ape, tlf, pas;
    private RadioButton h, m;

    //Método constructor de la segunda ventana
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        //Con setContentView establecemos todos los elementos gráficos de la ventana
        setContentView(R.layout.activity_registro);

        //Asociamos nuestras variables al elemento gráfico que corresponde
        nom = (EditText)findViewById(R.id.tNombre);
        ape = (EditText)findViewById(R.id.tApellidos);
        tlf = (EditText)findViewById((R.id.tTlf));
        pas = (EditText)findViewById(R.id.tPassword);
        h = (RadioButton)findViewById(R.id.oHombre);
        m = (RadioButton)findViewById(R.id.oMujer);
    }

    //Método que nos permite cerrar la aplicación (se activa al pulsar el botón bCerrar
    public void cerrar(View view){
        //Finalizamos la ventana
        finish();
        //Finalizamos el programa
        System.exit(0);
    }

    //Método que se activa al pulsar el botón bRegistrar
    //Crea una nueva ventana de la clase Confirmacion y le manda los datos almacenados en el formulario

    public void registrar(View view){
        //Guardamos en variables el contenido del formulario
        String nombre = nom.getText().toString();
        String apellidos = ape.getText().toString();
        String telefono = tlf.getText().toString();
        String contrasenia = pas.getText().toString();
        String sexo = "";

        /*Condicional que comprueba si alguno de los campos se ha dejado vacío o si no se ha marcado ninguna de las dos opciones
        * del RadioGroup*/
        if(nombre.length()==0 || apellidos.length()==0 || tlf.length()==0 || contrasenia.length()== 0 || (!h.isChecked() && !m.isChecked())) {
            /*En caso de que algún dato no se haya completado creamos un mensaje emergente de la clase Toast
             * que notifica al usuario que tiene que meter todos los datos y mostramos la notificación*/
            Toast notificacion = Toast.makeText(this, "Ningún campo puede quedar vacío. Rellénelos", Toast.LENGTH_LONG);
            notificacion.show();
        }else if(!validatePassword(contrasenia)){
            /*Si están todos los campos rellenos, comprobamos que la contraseña sea válida
            * Para ello usamos el método validatePassword que nos devolverá un booleano indicando si es válida (true) o si no (false)
            * En caso de que no sea válida, mostraremos un mensaje de la clase Toast indicando los requisitos de la contraseña (que se especifican en el método validatePassword)
            * */
            Toast notificacion = Toast.makeText(this, "Contraseña NO válida. Incluya una mayúscula, una minúscula y un número. La longitud debe ser de 8-15 caracteres", Toast.LENGTH_LONG);
            notificacion.show();
            //Vaciamos el campo de la contraseña para que introduzca información válida
            pas.setText("");

        }else{
            //Si todos los campos están rellenos y la contraseña es válida pasaremos los datos a la ventana de confirmación

                //Comprobamos la opción marcada del RadioGroup para asignarle valor a la variable sexo en función de la opción
                if (h.isChecked()) {
                    sexo = "Hombre";
                } else if (m.isChecked()) {
                    sexo = "Mujer";
                }

                //Creamos una nueva instancia de la clase Confirmacion (donde se mostrarán todos los datos)
                Intent x = new Intent(this, Confirmacion.class);
                /*Con el método putExtra podemos enviar parámetros al Activity que acabamos de instanciar,
                 * asociando clave-valor de dichos parámetros para su posterior recuperación*/
                x.putExtra("nombre", nombre);
                x.putExtra("apellidos", apellidos);
                x.putExtra("telefono", telefono);
                x.putExtra("contrasenia", contrasenia);
                x.putExtra("sexo", sexo);
                //Finalmente iniciamos la actividad de la clase Confirmacion
                startActivity(x);
                //Cerramos esta ventana
                finish();
        }
    }

    //Método que comprueba si una contraseña es válida
    private boolean validatePassword(String contrasenia){
        /*Para ello usaremos las regular expressions
        /*Primero creamos una cadena con todos los requisitos de la expresión regular. En nuestro caso:
        * -Debe contener (?=) algún(.*) dígito([0-9])
        * -Debe contener (?=) alguna(.*) letra minúscula([a-z])
        * -Debe contener (?=) alguna(.*) letra mayúscula([A-Z])
        * -Su longitud debe ser de 8 a 15 caracteres{8,15}*/
        String regex = "^(?=.*[0-9])(?=.*[a-z])(?=.*[A-Z]).{8,15}$";

        /*Compilamos la expresión regular en una instancia de la clase Pattern (compilamos la regez como un patrón), que es la habilitada
        * para usarse con la clase Matcher para comparar la expresión regular con la cadena que queremos saber si se ajusta a dicho expresión*/
        Pattern pattern = Pattern.compile(regex);

        /*El método matcher establece las coincidencias entre el patrón compilado y la cadena que le pasamos como parámetro*/
        Matcher matcher = pattern.matcher(contrasenia);
            //El método matches, finalmente, nos devuelve un booleano indicando si coinciden (true) o si no(false)
            return matcher.matches();
    }
}